using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ProductElasticSeaech
    {
        public ProductElasticSeaech()
        {
            Locales = new List<ProductLocalizedModel>();
            ProductPictureModels = new List<ProductPictureModel>();
            CopyProductModel = new CopyProductModel();
            AvailableProductTemplates = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
            AvailableTaxCategories = new List<SelectListItem>();
            AvailableDeliveryDates = new List<SelectListItem>();
            AvailableWarehouses = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableProductAttributes = new List<SelectListItem>();
            AddPictureModel = new ProductPictureModel();
            AddSpecificationAttributeModel = new AddProductSpecificationAttributeModel();
            ProductWarehouseInventoryModels = new List<ProductWarehouseInventoryModel>();
            CompleteProductAttributesModel = new CompleteProductAttributeModel();
            ArtworkAttributesModel = new ArtworkAttributeModel();
            AvailableArtworkTypes = new List<SelectListItem>();
            EditionLetters = new List<SelectListItem>();
            ProductAttributes = new List<ProductDetailsModel.ProductAttributeModel>();
        }
        public IList<ProductDetailsModel.ProductAttributeModel> ProductAttributes { get; set; }

        public string ArtistName { get; set; }
        public int Id { get; set; }
        public string PictureThumbnailUrl { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public string PartialProductNumber { get; set; }
        public int AssociatedToProductId { get; set; }
        public string AssociatedToProductName { get; set; }
        public int ChildOfProductId { get; set; }
        public string ChildOfProductName { get; set; }
        public bool VisibleIndividually { get; set; }
        public int ProductTemplateId { get; set; }
        public IList<SelectListItem> AvailableProductTemplates { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string AdminComment { get; set; }
        public int VendorId { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }
        public bool ShowOnHomePage { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public string SeName { get; set; }
        public bool AllowCustomerReviews { get; set; }
        public string ProductTags { get; set; }
        public string Sku { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public virtual string Gtin { get; set; }
        public bool IsGiftCard { get; set; }
        public int GiftCardTypeId { get; set; }
        public bool RequireOtherProducts { get; set; }
        public string RequiredProductIds { get; set; }
        public bool AutomaticallyAddRequiredProducts { get; set; }
        public bool IsDownload { get; set; }
        public int DownloadId { get; set; }
        public bool UnlimitedDownloads { get; set; }
        public int MaxNumberOfDownloads { get; set; }
        public int? DownloadExpirationDays { get; set; }
        public int DownloadActivationTypeId { get; set; }
        public bool HasSampleDownload { get; set; }
        public int SampleDownloadId { get; set; }
        public bool HasUserAgreement { get; set; }
        public string UserAgreementText { get; set; }
        public bool IsRecurring { get; set; }
        public int RecurringCycleLength { get; set; }
        public int RecurringCyclePeriodId { get; set; }
        public int RecurringTotalCycles { get; set; }
        public bool IsRental { get; set; }
        public int RentalPriceLength { get; set; }
        public int RentalPricePeriodId { get; set; }
        public bool IsShipEnabled { get; set; }
        public bool IsFreeShipping { get; set; }
        public bool ShipSeparately { get; set; }
        public decimal AdditionalShippingCharge { get; set; }
        public int DeliveryDateId { get; set; }
        public IList<SelectListItem> AvailableDeliveryDates { get; set; }
        public bool IsTaxExempt { get; set; }
        public int TaxCategoryId { get; set; }
        public IList<SelectListItem> AvailableTaxCategories { get; set; }
        public bool IsTelecommunicationsOrBroadcastingOrElectronicServices { get; set; }
        public int ManageInventoryMethodId { get; set; }
        public bool UseMultipleWarehouses { get; set; }
        public int WarehouseId { get; set; }
        public IList<SelectListItem> AvailableWarehouses { get; set; }
        public int StockQuantity { get; set; }
        public bool DisplayStockAvailability { get; set; }
        public bool DisplayStockQuantity { get; set; }
        public int MinStockQuantity { get; set; }
        public int LowStockActivityId { get; set; }
        public int NotifyAdminForQuantityBelow { get; set; }
        public int BackorderModeId { get; set; }
        public bool AllowBackInStockSubscriptions { get; set; }
        public int OrderMinimumQuantity { get; set; }
        public int OrderMaximumQuantity { get; set; }
        public string AllowedQuantities { get; set; }
        public bool AllowAddingOnlyExistingAttributeCombinations { get; set; }
        public bool DisableBuyButton { get; set; }
        public bool DisableWishlistButton { get; set; }
        public bool AvailableForPreOrder { get; set; }
        public DateTime? PreOrderAvailabilityStartDateTimeUtc { get; set; }
        public bool CallForPrice { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public decimal ProductCost { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialPriceStartDateTimeUtc { get; set; }
        public DateTime? SpecialPriceEndDateTimeUtc { get; set; }
        public bool CustomerEntersPrice { get; set; }
        public decimal MinimumCustomerEnteredPrice { get; set; }
        public decimal MaximumCustomerEnteredPrice { get; set; }
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public DateTime? AvailableStartDateTimeUtc { get; set; }
        public DateTime? AvailableEndDateTimeUtc { get; set; }
        public int DisplayOrder { get; set; }
        public bool Published { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }


        public string PrimaryStoreCurrencyCode { get; set; }
        public string BaseDimensionIn { get; set; }
        public string BaseWeightIn { get; set; }

        public IList<ProductLocalizedModel> Locales { get; set; }
        public bool SubjectToAcl { get; set; }
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public int[] SelectedCustomerRoleIds { get; set; }
        public bool LimitedToStores { get; set; }
        public List<StoreModel> AvailableStores { get; set; }
        public int[] SelectedStoreIds { get; set; }


        //vendor
        public bool IsLoggedInAsVendor { get; set; }



        //categories
        public IList<SelectListItem> AvailableCategories { get; set; }
        //manufacturers
        public IList<SelectListItem> AvailableManufacturers { get; set; }
        //product attributes
        public IList<SelectListItem> AvailableProductAttributes { get; set; }



        //pictures
        public ProductPictureModel AddPictureModel { get; set; }
        public IList<ProductPictureModel> ProductPictureModels { get; set; }

        //discounts
        public List<DiscountModel> AvailableDiscounts { get; set; }
        public int[] SelectedDiscountIds { get; set; }
        public AddProductSpecificationAttributeModel AddSpecificationAttributeModel { get; set; }
        public IList<ProductWarehouseInventoryModel> ProductWarehouseInventoryModels { get; set; }

        //copy product
        public CopyProductModel CopyProductModel { get; set; }

        public AAPProductType ProductType { get; set; }

        public CompleteProductAttributeModel CompleteProductAttributesModel { get; set; }

        public IList<SelectListItem> AvailableArtworkTypes { get; set; }

        public ArtworkAttributeModel ArtworkAttributesModel { get; set; }

        public ArtworksModel CanvasesModel { get; set; }
        public ArtworksModel ArtworksModel { get; set; }

        public IList<SelectListItem> EditionLetters { get; set; }

        public partial class CompleteProductAttributeModel : BaseNopEntityModel
        {
            public int ProductId { get; set; }
            public int CanvasId { get; set; }
            public int ArtworkId { get; set; }

        }

        public partial class ArtworkAttributeModel : BaseNopEntityModel
        {
            public int ArtistId { get; set; }
            public int ArtworkId { get; set; }
            public bool IsEdition { get; set; }
            public bool IsLimited { get; set; }
            public int SeriesNumber { get; set; }
            public int Quantity { get; set; }
            public string EditionSizeLetter { get; set; }

        }

        public partial class AddRequiredProductModel
        {
            public AddRequiredProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            public string SearchProductName { get; set; }
            public int SearchCategoryId { get; set; }
            public int SearchManufacturerId { get; set; }
            public int SearchStoreId { get; set; }
            public int SearchVendorId { get; set; }
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class AddProductSpecificationAttributeModel
        {
            public AddProductSpecificationAttributeModel()
            {
                AvailableAttributes = new List<SelectListItem>();
                AvailableOptions = new List<SelectListItem>();
            }

            public int SpecificationAttributeId { get; set; }
            public int AttributeTypeId { get; set; }
            public int SpecificationAttributeOptionId { get; set; }
            public string CustomValue { get; set; }
            public bool AllowFiltering { get; set; }
            public bool ShowOnProductPage { get; set; }
            public int DisplayOrder { get; set; }

            public IList<SelectListItem> AvailableAttributes { get; set; }
            public IList<SelectListItem> AvailableOptions { get; set; }
        }

        public partial class ProductPictureModel : BaseNopEntityModel
        {
            public int ProductId { get; set; }
            public int PictureId { get; set; }
            public string PictureUrl { get; set; }
            public int DisplayOrder { get; set; }
            public string VideoUrl { get; set; }
            public bool IsVideo { get; set; }
        }

        public partial class ProductCategoryModel : BaseNopEntityModel
        {
            public string Category { get; set; }

            public int ProductId { get; set; }

            public int CategoryId { get; set; }
            public bool IsFeaturedProduct { get; set; }
            public int DisplayOrder { get; set; }
        }

        public partial class ProductManufacturerModel : BaseNopEntityModel
        {
            public string Manufacturer { get; set; }

            public int ProductId { get; set; }

            public int ManufacturerId { get; set; }
            public bool IsFeaturedProduct { get; set; }
            public int DisplayOrder { get; set; }
        }

        public partial class RelatedProductModel : BaseNopEntityModel
        {
            public int ProductId2 { get; set; }
            public string Product2Name { get; set; }
            public int DisplayOrder { get; set; }
            public string Sku { get; set; }
            public bool IsSold { get; set; }
        }
        public partial class AddRelatedProductModel
        {
            public AddRelatedProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            public string SearchProductName { get; set; }
            public int SearchCategoryId { get; set; }
            public int SearchManufacturerId { get; set; }
            public int SearchStoreId { get; set; }
            public int SearchVendorId { get; set; }
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public int ProductId { get; set; }

            public int[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class AssociatedProductModel : BaseNopEntityModel
        {
            public string ProductName { get; set; }
            public int DisplayOrder { get; set; }
        }
        public partial class AddAssociatedProductModel
        {
            public AddAssociatedProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            public string SearchProductName { get; set; }
            public int SearchCategoryId { get; set; }
            public int SearchManufacturerId { get; set; }
            public int SearchStoreId { get; set; }
            public int SearchVendorId { get; set; }
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public int ProductId { get; set; }

            public int[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class CrossSellProductModel : BaseNopEntityModel
        {
            public int ProductId2 { get; set; }
            public string Product2Name { get; set; }
        }
        public partial class AddCrossSellProductModel
        {
            public AddCrossSellProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            public string SearchProductName { get; set; }
            public int SearchCategoryId { get; set; }
            public int SearchManufacturerId { get; set; }
            public int SearchStoreId { get; set; }
            public int SearchVendorId { get; set; }
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public int ProductId { get; set; }

            public int[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class TierPriceModel : BaseNopEntityModel
        {
            public int ProductId { get; set; }

            public int CustomerRoleId { get; set; }
            public string CustomerRole { get; set; }


            public int StoreId { get; set; }
            public string Store { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
        }

        public partial class ProductWarehouseInventoryModel
        {
            public int WarehouseId { get; set; }
            public string WarehouseName { get; set; }
            public bool WarehouseUsed { get; set; }
            public int StockQuantity { get; set; }
            public int ReservedQuantity { get; set; }
            public int PlannedQuantity { get; set; }
        }


        public partial class ProductAttributeMappingModel : BaseNopEntityModel
        {
            public int ProductId { get; set; }

            public int ProductAttributeId { get; set; }
            public string ProductAttribute { get; set; }
            public string TextPrompt { get; set; }
            public bool IsRequired { get; set; }

            public int AttributeControlTypeId { get; set; }
            public string AttributeControlType { get; set; }
            public int DisplayOrder { get; set; }

            public string ViewEditValuesUrl { get; set; }
            public string ViewEditValuesText { get; set; }
            public bool ValidationRulesAllowed { get; set; }
            public int? ValidationMinLength { get; set; }
            public int? ValidationMaxLength { get; set; }
            public string ValidationFileAllowedExtensions { get; set; }
            public int? ValidationFileMaximumSize { get; set; }
            public string DefaultValue { get; set; }
        }
        public partial class ProductAttributeValueListModel
        {
            public int ProductId { get; set; }

            public string ProductName { get; set; }

            public int ProductAttributeMappingId { get; set; }

            public string ProductAttributeName { get; set; }
        }

        public partial class ProductAttributeValueModel : BaseNopEntityModel, ILocalizedModel<ProductAttributeValueLocalizedModel>
        {
            public ProductAttributeValueModel()
            {
                ProductPictureModels = new List<ProductPictureModel>();
                Locales = new List<ProductAttributeValueLocalizedModel>();
            }

            public int ProductAttributeMappingId { get; set; }
            public int AttributeValueTypeId { get; set; }
            public string AttributeValueTypeName { get; set; }
            public int AssociatedProductId { get; set; }
            public string AssociatedProductName { get; set; }
            public string Name { get; set; }
            public string ColorSquaresRgb { get; set; }
            public bool DisplayColorSquaresRgb { get; set; }
            public decimal PriceAdjustment { get; set; }
            //used only on the values list page
            public string PriceAdjustmentStr { get; set; }
            public decimal WeightAdjustment { get; set; }
            //used only on the values list page
            public string WeightAdjustmentStr { get; set; }
            public decimal Cost { get; set; }
            public int Quantity { get; set; }
            public bool IsPreSelected { get; set; }
            public int DisplayOrder { get; set; }
            public int PictureId { get; set; }
            public string PictureThumbnailUrl { get; set; }

            public IList<ProductPictureModel> ProductPictureModels { get; set; }
            public IList<ProductAttributeValueLocalizedModel> Locales { get; set; }

            public partial class AssociateProductToAttributeValueModel
            {
                public AssociateProductToAttributeValueModel()
                {
                    AvailableCategories = new List<SelectListItem>();
                    AvailableManufacturers = new List<SelectListItem>();
                    AvailableStores = new List<SelectListItem>();
                    AvailableVendors = new List<SelectListItem>();
                    AvailableProductTypes = new List<SelectListItem>();
                }
                public string SearchProductName { get; set; }
                public int SearchCategoryId { get; set; }
                public int SearchManufacturerId { get; set; }
                public int SearchStoreId { get; set; }
                public int SearchVendorId { get; set; }
                public int SearchProductTypeId { get; set; }

                public IList<SelectListItem> AvailableCategories { get; set; }
                public IList<SelectListItem> AvailableManufacturers { get; set; }
                public IList<SelectListItem> AvailableStores { get; set; }
                public IList<SelectListItem> AvailableVendors { get; set; }
                public IList<SelectListItem> AvailableProductTypes { get; set; }

                //vendor
                public bool IsLoggedInAsVendor { get; set; }


                public int AssociatedToProductId { get; set; }
            }
        }
        public partial class ProductAttributeValueLocalizedModel
        {
            public int LanguageId { get; set; }
            public string Name { get; set; }
        }
        public partial class ProductAttributeCombinationModel : BaseNopEntityModel
        {
            public int ProductId { get; set; }
            public string AttributesXml { get; set; }
            public string Warnings { get; set; }
            public int StockQuantity { get; set; }
            public bool AllowOutOfStockOrders { get; set; }
            public string Sku { get; set; }
            public string ManufacturerPartNumber { get; set; }
            public string Gtin { get; set; }
            public decimal? OverriddenPrice { get; set; }
            public int NotifyAdminForQuantityBelow { get; set; }

        }
    }

    public partial class BaseNopEntityModel
    {
        public virtual int Id { get; set; }
    }

    public partial class ProductLocalizedModel
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public string SeName { get; set; }
    }

    public enum AAPProductType
    {
        DefaultProduct = 0,
        CompleteProduct = 1,
        Canvas = 2,
        ApprovedArtwork = 3,
        FinishedProduct = 4
    }

    public interface ILocalizedModel
    {

    }
    public interface ILocalizedModel<TLocalizedModel> : ILocalizedModel
    {
        IList<TLocalizedModel> Locales { get; set; }
    }

    public class ArtworksModel
    {
        public ArtworksModel()
        {
            Artworks = new List<ArtworkModel>();
        }

        public int SelectedArtworkId { get; set; }
        public IList<ArtworkModel> Artworks { get; set; }
    }

    public class ArtworkModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureThumbnailUrl { get; set; }
        public string LimitEditionNumber { get; set; }

        public bool IsLimited { get; set; }
        public int EditionQuantity { get; set; }
        public int SerialNumber { get; set; }
    }

    public partial class CopyProductModel : BaseNopEntityModel
    {
        public string Name { get; set; }
        public bool CopyImages { get; set; }
        public bool Published { get; set; }
    }

    public partial class DiscountModel : BaseNopEntityModel
    {
        public DiscountModel()
        {
            AppliedToCategoryModels = new List<AppliedToCategoryModel>();
            AppliedToProductModels = new List<AppliedToProductModel>();
            AvailableDiscountRequirementRules = new List<SelectListItem>();
            DiscountRequirementMetaInfos = new List<DiscountRequirementMetaInfo>();
        }
        public string Name { get; set; }
        public int DiscountCategoryId { get; set; }
        public int DiscountTypeId { get; set; }
        public bool UsePercentage { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public string PrimaryStoreCurrencyCode { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
        public bool RequiresCouponCode { get; set; }
        public string CouponCode { get; set; }
        public int DiscountLimitationId { get; set; }
        public int LimitationTimes { get; set; }
        public int? MaximumDiscountedQuantity { get; set; }
        public string AddDiscountRequirement { get; set; }

        public IList<AppliedToProductModel> AppliedToProductModels { get; set; }
        public IList<AppliedToCategoryModel> AppliedToCategoryModels { get; set; }
        public IList<SelectListItem> AvailableDiscountRequirementRules { get; set; }
        public IList<DiscountRequirementMetaInfo> DiscountRequirementMetaInfos { get; set; }

        public partial class DiscountRequirementMetaInfo 
        {
            public int DiscountRequirementId { get; set; }
            public string RuleName { get; set; }
            public string ConfigurationUrl { get; set; }
        }

        public partial class DiscountUsageHistoryModel : BaseNopEntityModel
        {
            public int DiscountId { get; set; }
            public int OrderId { get; set; }
            public DateTime CreatedOn { get; set; }
        }

        public partial class AppliedToCategoryModel
        {
            public int CategoryId { get; set; }

            public string Name { get; set; }
        }

        public partial class AppliedToProductModel
        {
            public int ProductId { get; set; }

            public string ProductName { get; set; }
        }
    }

    public partial class StoreModel : BaseNopEntityModel, ILocalizedModel<StoreLocalizedModel>
    {
        public StoreModel()
        {
            Locales = new List<StoreLocalizedModel>();
        }

        public string Name { get; set; }
        public string Url { get; set; }
        public virtual bool SslEnabled { get; set; }
        public virtual string SecureUrl { get; set; }
        public string Hosts { get; set; }
        public int DisplayOrder { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyVat { get; set; }


        public IList<StoreLocalizedModel> Locales { get; set; }
    }

    public partial class StoreLocalizedModel
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }

    public partial class ProductDetailsModel : BaseNopEntityModel
    {
        public partial class ProductAttributeModel : BaseNopEntityModel
        {
            public ProductAttributeModel()
            {
                AllowedFileExtensions = new List<string>();
                Values = new List<ProductAttributeValueModel>();
            }

            public int ProductId { get; set; }

            public int ProductAttributeId { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string TextPrompt { get; set; }

            public bool IsRequired { get; set; }

            /// <summary>
            /// Default value for textboxes
            /// </summary>
            public string DefaultValue { get; set; }
            /// <summary>
            /// Selected day value for datepicker
            /// </summary>
            public int? SelectedDay { get; set; }
            /// <summary>
            /// Selected month value for datepicker
            /// </summary>
            public int? SelectedMonth { get; set; }
            /// <summary>
            /// Selected year value for datepicker
            /// </summary>
            public int? SelectedYear { get; set; }

            /// <summary>
            /// Allowed file extensions for customer uploaded files
            /// </summary>
            public IList<string> AllowedFileExtensions { get; set; }

            public AttributeControlType AttributeControlType { get; set; }

            public IList<ProductAttributeValueModel> Values { get; set; }

        }

        public partial class ProductAttributeValueModel : BaseNopEntityModel
        {
            public string Name { get; set; }

            public string ColorSquaresRgb { get; set; }

            public string PriceAdjustment { get; set; }

            public decimal PriceAdjustmentValue { get; set; }

            public bool IsPreSelected { get; set; }

            public int PictureId { get; set; }
            public string PictureUrl { get; set; }
            public string FullSizePictureUrl { get; set; }
        }

        public enum AttributeControlType
        {
            /// <summary>
            /// Dropdown list
            /// </summary>
            DropdownList = 1,
            /// <summary>
            /// Radio list
            /// </summary>
            RadioList = 2,
            /// <summary>
            /// Checkboxes
            /// </summary>
            Checkboxes = 3,
            /// <summary>
            /// TextBox
            /// </summary>
            TextBox = 4,
            /// <summary>
            /// Multiline textbox
            /// </summary>
            MultilineTextbox = 10,
            /// <summary>
            /// Datepicker
            /// </summary>
            Datepicker = 20,
            /// <summary>
            /// File upload control
            /// </summary>
            FileUpload = 30,
            /// <summary>
            /// Color squares
            /// </summary>
            ColorSquares = 40,
            /// <summary>
            /// Read-only checkboxes
            /// </summary>
            ReadonlyCheckboxes = 50,
        }
    }

    public partial class CustomerRoleModel : BaseNopEntityModel
    {
        public string Name { get; set; }
        public bool FreeShipping { get; set; }
        public bool TaxExempt { get; set; }
        public bool Active { get; set; }
        public bool IsSystemRole { get; set; }
        public string SystemName { get; set; }
        public int PurchasedWithProductId { get; set; }
        public string PurchasedWithProductName { get; set; }

        public partial class AssociateProductToCustomerRoleModel
        {
            public AssociateProductToCustomerRoleModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }
            public string SearchProductName { get; set; }
            public int SearchCategoryId { get; set; }
            public int SearchManufacturerId { get; set; }
            public int SearchStoreId { get; set; }
            public int SearchVendorId { get; set; }
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }


            public int AssociatedToProductId { get; set; }
        }
    }
}
