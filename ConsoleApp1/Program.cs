using Elasticsearch.Net;
using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public static class Program
    {
        private const string _elasticsearchUrl = "https://search-aap-elasticsearch-oig44h344whlcn7s2ribqrrb4q.us-east-1.es.amazonaws.com";
        private const string _elasticsearchIndexName = "aap-local";

        private static void Main(string[] args)
        {
            //InitDataElasticSearch();
            //ElasticSearch();

            Console.WriteLine("Done!");

            Console.ReadLine();
        }

        public static void Stripe()
        {
            var stripeAPI = new StripeAPI();
            var cardNumber = "5555555555554444";//"4242424242424242";
            var expMonth = 2;
            var expYear = 2021;
            var cvc = "123";
            //var customer = stripeAPI.GetCustomer("cus_Gj5714I5g0hSJ6");
            //var token = stripeAPI.CreateCardTokens(cardNumber, expMonth, expYear, cvc);
            //stripeAPI.AddCard("cus_GyQb5rf11O0eAn", token); card_1GQn3uBqhCJKs3Kh97U975Ch
            stripeAPI.RemoveCard("cus_GyQb5rf11O0eAn", "card_1GQn3uBqhCJKs3Kh97U975Ch");
            //var customer = stripeAPI.CreateCustomer("Tan Hoang Ngoc", "rain9x@gmail.com", token);
            //var customer = stripeAPI.UpdateCustomerCard("cus_Gj5714I5g0hSJ6", token);
            //stripeAPI.Charge("cus_Gj5714I5g0hSJ6", 250, 12345);
            //stripeAPI.Refund("ch_1GOIjOBqhCJKs3KhrdVe9PaP", 100);
            //stripeAPI.CreateAccount("Rain", "Sym", "tanhn90@gmail.com");
            //stripeAPI.Payout(100, "acct_1GI5jLABdCxpahjD", 120);
        }

        private static Dictionary<string, object> ConvertToDictionary(this object obj)
        {
            return obj.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .ToDictionary(prop => prop.Name, prop => prop.GetValue(obj) == null ? "" : prop.GetValue(obj));
        }

        private static void InitDataElasticSearch()
        {
            var settings = new ConnectionSettings(new Uri(_elasticsearchUrl)).DefaultIndex(_elasticsearchIndexName);
            var client = new ElasticClient(settings);

            var products = ReadJsonFile<List<ProductElasticSearch>>("D:\\Work\\Personal\\ConsoleApp\\ConsoleApp1\\AAPProduct.json");
            //var res = client.IndexDocument(products.First());
            var res = client.IndexMany(products);
            Console.WriteLine($"Index result: {res.DebugInformation}");
        }

        private static void DeleteIndexNameElasticSearch()
        {
            var settings = new ConnectionSettings(new Uri(_elasticsearchUrl)).DefaultIndex(_elasticsearchIndexName);
            var client = new ElasticClient(settings);

            var deleteRes = client.Indices.Delete(_elasticsearchIndexName);
            return;
        }

        public static void ElasticSearch()
        {
            var settings = new ConnectionSettings(new Uri(_elasticsearchUrl)).DefaultIndex(_elasticsearchIndexName);
            var client = new ElasticClient(settings);

            QueryContainer queryContainer = null;
            //queryContainer &= new QueryContainerDescriptor<ProductElasticSearch>().Term(t => t.ParentGroupedProductId, 7423);
            //queryContainer &= new QueryContainerDescriptor<ProductElasticSearch>().Term(t => t.ProductType, ProductType.SimpleProduct);
            //queryContainer &= new QueryContainerDescriptor<ProductElasticSearch>().Range(r => r.Field(f => f.SpecialPrice).GreaterThanOrEquals(1));
            queryContainer &= new QueryContainerDescriptor<ProductElasticSearch>()
                                    .Bool(b => b.Must(m =>
                                            m.Range(t => t.Field(f => f.SpecialPrice).GreaterThanOrEquals(0))
                                            &&
                                            m.Range(t => t.Field(f => f.SpecialPrice).LessThanOrEquals(20))
                                    ));

            var searchRequest = new SearchRequest<RV>
            {
                Query = queryContainer,
                From = 0,
                Size = 20,
            };

            var json = client.RequestResponseSerializer.SerializeToString(searchRequest);

            var searchResponse = client.Search<ProductElasticSearch>(searchRequest);
            Console.WriteLine($"Query result: {searchResponse.DebugInformation}\r\nNumber of document: {searchResponse.Documents.Count()}");

            var products = searchResponse.Documents;
            var index = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{index} Product name: {product.Name}");
                index++;
            }
            //foreach (var hit in searchResponse.Hits)
            //{
            //    var rv = hit.Source;
            //    var field = hit.Fields["distance"];
            //    if (field != null)
            //    {
            //        rv.Distance = field.As<JArray>().Value<double>(0);
            //    }

            //    rvs.Add(rv);
            //}

            return;
        }

        public static void UpdateElasticSearch()
        {
            var settings = new ConnectionSettings(new Uri("https://search-search-rvezy-sdxhps7oh6vgvoy7f3ctpxnh7q.us-east-2.es.amazonaws.com")).DefaultIndex("rv-local");
            var client = new ElasticClient(settings);

            var descriptor = new BulkDescriptor();
            for (int i = 0; i < 2; i++)
            {
                var id = "a306e70e-1ab1-4dde-9c58-31e677762af6";
                var score = 8.8;
                if (i == 1)
                {
                    id = "8fbfb724-8ebb-4bc0-82b0-5a1cf52fd2cc";
                    score = 10;
                }
                descriptor.Update<RV>(u => u
                                            .Id(id)
                                            .Doc(new RV { Id = new Guid(id), Score = score }));
            }

            var result = client.Bulk(descriptor);
        }

        public static TResponse ReadJsonFile<TResponse>(this string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<TResponse>(json);
            }
        }

        public static string ReadFile(this string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                return json;
            }
        }

        public static void WriteJsonFile(this object model, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(model));
        }

        public static string ConvertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static IDictionary<string, object> ToDictionary(this object source)
        {
            return source.ToDictionary<object>();
        }

        public static IDictionary<string, T> ToDictionary<T>(this object source)
        {
            if (source == null) return null;

            var dictionary = new Dictionary<string, T>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
                AddPropertyToDictionary<T>(property, source, dictionary);
            return dictionary;
        }

        private static void AddPropertyToDictionary<T>(PropertyDescriptor property, object source, Dictionary<string, T> dictionary)
        {
            object value = property.GetValue(source);
            if (IsOfType<T>(value))
                dictionary.Add(property.Name, (T)value);
        }

        private static bool IsOfType<T>(object value)
        {
            return value is T;
        }

        /// <summary>
        /// Hashing password with SHA-1 algorithm
        /// </summary>
        /// <param name="password">String to be hashed</param>
        /// <returns>40-character hex string</returns>
        private static string SHA1HashPassword(this string password)
        {
            if (string.IsNullOrEmpty(password)) { return null; }

            byte[] bytes = Encoding.UTF8.GetBytes(password);

            var sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(bytes);

            return HexStringFromBytes(hashBytes);
        }

        /// <summary>
        /// Convert an array of bytes to a string of hex digits
        /// </summary>
        /// <param name="bytes">array of bytes</param>
        /// <returns>String of hex digits</returns>
        private static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }

        // Return start day of week - Monday is first day of week
        public static DateTime GetStartTime(GoalFrequency type)
        {
            var res = new DateTime();

            var today = DateTime.Now;
            if (type == GoalFrequency.Weekly)
            {
                res = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);
                switch (today.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        res = res.AddDays(-1);
                        break;

                    case DayOfWeek.Tuesday:
                        res = res.AddDays(-2);
                        break;

                    case DayOfWeek.Wednesday:
                        res = res.AddDays(-3);
                        break;

                    case DayOfWeek.Thursday:
                        res = res.AddDays(-4);
                        break;

                    case DayOfWeek.Friday:
                        res = res.AddDays(-5);
                        break;

                    case DayOfWeek.Saturday:
                        res = res.AddDays(-6);
                        break;
                }
            }
            else if (type == GoalFrequency.Monthly)
            {
                res = new DateTime(today.Year, today.Month, 1, 0, 0, 0);
            }
            else
            {
                res = new DateTime(today.Year, today.Month, 1, 0, 0, 0);
                switch (today.Month % 3)
                {
                    case 0:
                        res = res.AddMonths(-2);
                        break;

                    case 2:
                        res = res.AddMonths(-1);
                        break;
                }
            }

            return res;
        }

        // Return last day of week - Sunday is last day of week
        public static DateTime GetEndTime(GoalFrequency type)
        {
            var res = new DateTime();

            var today = DateTime.Now;
            if (type == GoalFrequency.Weekly)
            {
                res = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);
                switch (today.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        res = res.AddDays(7);
                        break;

                    case DayOfWeek.Monday:
                        res = res.AddDays(6);
                        break;

                    case DayOfWeek.Tuesday:
                        res = res.AddDays(5);
                        break;

                    case DayOfWeek.Wednesday:
                        res = res.AddDays(4);
                        break;

                    case DayOfWeek.Thursday:
                        res = res.AddDays(3);
                        break;

                    case DayOfWeek.Friday:
                        res = res.AddDays(2);
                        break;
                }
            }
            else if (type == GoalFrequency.Monthly)
            {
                res = new DateTime(today.Year, today.Month + 1, 1, 0, 0, 0);
            }
            else
            {
                res = new DateTime(today.Year, today.Month, 1, 0, 0, 0);
                switch (today.Month % 3)
                {
                    case 1:
                        res = res.AddMonths(3);
                        break;

                    case 2:
                        res = res.AddMonths(2);
                        break;
                }
            }

            return res.AddSeconds(-1);
        }
    }

    public enum GoalFrequency { Weekly, Monthly, Quarterly }
}