﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using System.Xml.Serialization;
using WebApplicationNetFramework.VCScoring;

namespace WebApplicationNetFramework.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public void Get()
        {
            //Call Scoring
            HeaderType hd = new HeaderType();
            hd.ClientTimeZoneID = "Asia/Ho_Chi_Minh";
            hd.Identity = "91";
            string eventName = "CFCScoring";
            EventService evt = new EventService();
            HeaderResponseType hdResp;

            DataItemResponseType resptt = new DataItemResponseType();


            DataItemResponseType[] respType = new DataItemResponseType[8];
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            //Declare data item
            DataItemType[] itemTypes = new DataItemType[51];
            itemTypes[0] = getScoreObjStr(DataItemTypeName.Application_Number, "APPTestbINH");
            itemTypes[1] = getScoreObjFloat(DataItemTypeName.Request_Limit, 1000000000.0);
            itemTypes[2] = getScoreObjStr(DataItemTypeName.Application_ID, "APPTestbINH");
            itemTypes[3] = getScoreObjStr(DataItemTypeName.Product, "101");
            itemTypes[4] = getScoreObjStr(DataItemTypeName.Credit_Card_Type, "THẺ TIỀN MẶT VIETCREDIT");
            itemTypes[5] = getScoreObjStr(DataItemTypeName.Promo_Code, "RET");
            itemTypes[6] = getScoreObjStr(DataItemTypeName.Age, "27");
            itemTypes[7] = getScoreObjStr(DataItemTypeName.Resident_Type, "LEASEHOLD");
            itemTypes[8] = getScoreObjStr(DataItemTypeName.Marital_Status, "Married");
            itemTypes[9] = getScoreObjStr(DataItemTypeName.Address_Type, "ResidentialAddress");

            itemTypes[10] = getScoreObjStr(DataItemTypeName.State, "VN");
            itemTypes[11] = getScoreObjStr(DataItemTypeName.City, "HCMI");
            itemTypes[12] = getScoreObjInt(DataItemTypeName.Number_of_Dependents, 1);
            itemTypes[13] = getScoreObjInt(DataItemTypeName.Number_of_Children, 2);
            itemTypes[14] = getScoreObjStr(DataItemTypeName.Occupation_Type, "Salaried");
            itemTypes[15] = getScoreObjStr(DataItemTypeName.Industry, "Others");
            itemTypes[16] = getScoreObjStr(DataItemTypeName.Nature_of_Business, "GRADUATION");
            itemTypes[17] = getScoreObjStr(DataItemTypeName.SubIndustry, "");
            itemTypes[18] = getScoreObjStr(DataItemTypeName.Company_Type, "Aut Body");
            itemTypes[19] = getScoreObjStr(DataItemTypeName.Employment_type, "Bằng hoặc lớn hơn 1 năm - Equal or more than 1 year");

            itemTypes[20] = getScoreObjStr(DataItemTypeName.Employment_Status, "Trưởng phòng/manager/deputy manager");
            itemTypes[21] = getScoreObjDate(DataItemTypeName.Employment_From, System.DateTime.Now);
            itemTypes[22] = getScoreObjFloat(DataItemTypeName.Years_In_Job, 0.7);
            itemTypes[23] = getScoreObjStr(DataItemTypeName.Employment_Location, "");
            itemTypes[24] = getScoreObjFloat(DataItemTypeName.Gross_Monthly_Income, 3000000);
            itemTypes[25] = getScoreObjStr(DataItemTypeName.Missing_Information, "");
            itemTypes[26] = getScoreObjStr(DataItemTypeName.Employer_Status, "Hoạt động - Working");
            itemTypes[27] = getScoreObjStr(DataItemTypeName.Employer_Establish_Day, "10");
            itemTypes[28] = getScoreObjFloat(DataItemTypeName.Annual_Net_Income, 180000000);
            itemTypes[29] = getScoreObjFloat(DataItemTypeName.Annual_Gross_Income, 150000000);

            itemTypes[30] = getScoreObjFloat(DataItemTypeName.Income_From_Other_Sources, 27000000);
            itemTypes[31] = getScoreObjFloat(DataItemTypeName.Card_Limit, 20000000);
            itemTypes[32] = getScoreObjStr(DataItemTypeName.Card_Expiry, "");
            itemTypes[33] = getScoreObjStr(DataItemTypeName.PCB_Response_XML, "");
            itemTypes[34] = getScoreObjInt(DataItemTypeName.Maximum_Worststatus, 1);
            itemTypes[35] = getScoreObjStr(DataItemTypeName.Result, "");
            itemTypes[36] = getScoreObjInt(DataItemTypeName.No_of_Contract, 0);
            itemTypes[37] = getScoreObjStr(DataItemTypeName.Results_2, "");
            itemTypes[38] = getScoreObjFloat(DataItemTypeName.Amount_of_Unpaid_Due_Installments, 0);
            itemTypes[39] = getScoreObjFloat(DataItemTypeName.Overdue_Not_Paid_Amount, 0);

            itemTypes[40] = getScoreObjFloat(DataItemTypeName.Total_Current_Overdue_Amount, 0);
            itemTypes[41] = getScoreObjStr(DataItemTypeName.Results_3, "");
            itemTypes[42] = getScoreObjFloat(DataItemTypeName.Number_of_Bank_Relationship, 0);
            itemTypes[43] = getScoreObjFloat(DataItemTypeName.No_of_Installment_Loans, 0);
            itemTypes[44] = getScoreObjFloat(DataItemTypeName.Total_Outstanding_Balances, 0);
            itemTypes[45] = getScoreObjFloat(DataItemTypeName.No_of_Credit_Cards, 0);
            itemTypes[46] = getScoreObjFloat(DataItemTypeName.Total_Credit_Limit, 0);
            itemTypes[47] = getScoreObjFloat(DataItemTypeName.Total_Oustanding_Balance_1, 0);
            itemTypes[48] = getScoreObjFloat(DataItemTypeName.No_Overdraft, 0);
            itemTypes[49] = getScoreObjFloat(DataItemTypeName.Total_Credit_Limit_1, 0);

            itemTypes[50] = getScoreObjFloat(DataItemTypeName.Total_Monthly_Payment_Excluding_Overdraft, 0);
            var stringwriter = new StringWriter();
            var xmlSerializer = new XmlSerializer(itemTypes.GetType());
            xmlSerializer.Serialize(stringwriter, itemTypes);
            var xml = stringwriter.ToString();

            hdResp = evt.Event(hd, itemTypes, ref eventName, out respType);
        }

        public DataItemType getScoreObjStr(DataItemTypeName dtItemName, string value)
        {
            DataItemType itemType = new DataItemType();
            itemType.name = dtItemName;
            VCScoring.String str = new VCScoring.String();
            str.Val = value;
            itemType.Item = str;
            return itemType;
        }

        public DataItemType getScoreObjInt(DataItemTypeName dtItemName, long value)
        {
            DataItemType itemType = new DataItemType();
            itemType.name = dtItemName;
            VCScoring.Int str = new VCScoring.Int();
            str.Val = value;
            str.ValSpecified = true;
            itemType.Item = str;
            return itemType;
        }

        public DataItemType getScoreObjFloat(DataItemTypeName dtItemName, double value)
        {
            DataItemType itemType = new DataItemType();
            itemType.name = dtItemName;
            VCScoring.Float str = new VCScoring.Float();
            str.Val = value;
            itemType.Item = str;
            str.ValSpecified = true;
            return itemType;
        }

        public DataItemType getScoreObjDate(DataItemTypeName dtItemName, System.DateTime value)
        {
            DataItemType itemType = new DataItemType();
            itemType.name = dtItemName;
            VCScoring.DateTime str = new VCScoring.DateTime();
            str.Val = value;
            itemType.Item = str;
            str.ValSpecified = true;
            return itemType;
        }
    }
}
