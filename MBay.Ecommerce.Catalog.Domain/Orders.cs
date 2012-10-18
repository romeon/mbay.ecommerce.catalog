using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MBay.Core.Domain;

namespace MBay.Core.Domain
{
    public class Orders
    {
        /*TODO: Add the following properties
          
         * OrderNumber -int
         * OrderID -Guid
         * StoreID -Guid
         * ParentOrderNumber -int
         * StoreVersion
         * QuoteCheckout -boolean
         * IsNew -boolean
         * ShippedOn -datetime
         * CustomerID -Guid
         * Referrer
         * Person -Person class
         * Billing Address - Address class
         * Shipping Address - Address class
         * ShippingMethodID -Guid
         * ShippingMethod
         * ShippingPhone
         * ShippingCalculationID -int
         * Phone
         * RegisterDate -datetime
         * CouponCode
         * CouponType -int
         * CouponDescription
         * CouponDiscountAmount -double
         * CouponDiscountPercent -double
         * CouponIncludesFreeShipping -boolean
         * OkToEmail -boolean
         * Deleted -boolean
         * CardType
         * CardName
         * CardNumber
         * CardExpirationMonth
         * CardExpirationYear
         * CardStartDate
         * CardIssueNumber
         * OrderSubtotal -double
         * OrderTax -double
         * OrderShippingCosts -double
         * OrderTotal -double
         * PaymentGateway
         * AuthorizationCode
         * AuthorizationResult
         * AuthorizationPNREF
         * TransactionCommand
         * OrderDate -datetime
         * LevelID -int
         * LevelName
         * LevelDiscountPercent -double
         * LevelDiscountAmount -double
         * LevelHasFreeShipping -boolean
         * LevelAllowsQuantityDiscounts -boolean
         * LevelHasNoTax -boolean
         * LevelAllowsCoupons -boolean
         * LevelDiscountsApplyToExtendedPrices -boolean
         * LastIPAddress
         * PaymentMethod
         * OrderNotes
         * PONumber
         * DownloadEmailSentOn -datetime
         * ReceiptEmailSentOn -datetime
         * DistributorEmailSentOn -datetime
         * ShippingTrackingNumber
         * ShippedVIA
         * CustomerServiceNotes
         * RTShipRequest
         * RTShipResponse
         * TransactionState
         * AVSResult
         * CaptureTXCommand
         * CaptureTXResult
         * VoidTXCommand
         * VoidTXResult
         * RefundTXCommand
         * RefundTXResult
         * RefundReason
         * CardinalLookupResult
         * CardinalAuthenticateResult
         * CardinalGatewayParms
         * OrderOptions
         * OrderWeight -double
         * eCheckBankABACode
         * eCheckBankAccountNumber
         * eCheckBankAccountType
         * eCheckBankName
         * eCheckBankAccountName
         * CarrierReportedRate
         * CarrierReportedWeight
         * LocaleSetting
         * FinalizationData
         * ExtensionData
         * AlreadyConfirmed -boolean
         * CartType -int
         * THUB_POSTED_TO_ACCOUNTING -char[]
         * THUB_POSTED_DATE -datetime
         * THUB_ACCOUNTING_REF
         * Last4
         * ReadyToShip -boolean
         * IsPrinted -boolean
         * AuthorizedOn -datetime
         * CapturedOn -datetime
         * RefundedOn -datetime
         * VoidedOn -datetime
         * FraudedOn -datetime
         * EditedOn -datetime
         * TrackingURL
         * ShippedEMailSentOn -datetime
         * InventoryWasReduced -int
         * MaxMindFraudScore -double
         * MaxMindDetails
         * VATRegistrationID
         * Crypt -int
         * TransactionType -int
         * RecurringSubscriptionID
         * RecurringSubscriptionCommand
         * RecurringSubscriptionResult
         * RelatedOrderNumber -int
         * BuySafeCommand
         * BuySafeResult
         */

        #region Properties
        public int OrderNumber { get; set; }
        public Guid OrderId { get; set; }
        public Guid StoreId { get; set; }
        public int ParentOrderNumber { get; set; }
        public string StoreVersion { get; set; }
        public Boolean QuoteCheckout { get; set; }
        public Boolean IsNew { get; set; }
        public DateTime ShippedOn { get; set; }
        public Guid CustomerId { get; set; }
        public string Referrer { get; set; }
        public Person Person { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public Guid ShippingMethodId { get; set; }
        public string ShippingMethod { get; set; }
        public string ShippingPhone { get; set; }
        public int ShippingCalculationId { get; set; }
        public string Phone { get; set; }
        public DateTime RegisterDate { get; set; }
        public string CouponCode { get; set; }
        public int CouponType { get; set; }
        public string CouponDescription { get; set; }
        public double CouponDiscountAmount { get; set; }
        public double CouponDiscountPercent { get; set; }
        public Boolean CouponIncludesFreeShipping { get; set; }
        public Boolean OkToEmail { get; set; }
        public Boolean Deleted { get; set; }
        public string CardType { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CardExpirationMonth { get; set; }
        public string CardExpirationYear { get; set; }
        public string CardStartDate { get; set; }
        public string CardIssueNumber { get; set; }
        public double OrderSubtotal { get; set; }
        public double OrderTax { get; set; }
        public double OrderShippingCosts { get; set; }
        public double OrderTotal { get; set; }
        public string PaymentGateway { get; set; }
        public string AuthorizationCode { get; set; }
        public string AuthorizationResult { get; set; }
        public string AuthorizationPNREF { get; set; }
        public string TransactionCommand { get; set; }
        public DateTime OrderDate { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public double LevelDiscountPercent { get; set; }
        public double LevelDiscountAmount { get; set; }
        public Boolean LevelHasFreeShipping { get; set; }
        public Boolean LevelAllowsQuantityDiscounts { get; set; }
        public Boolean LevelHasNoTax { get; set; }
        public Boolean LevelAllowsCoupons { get; set; }
        public Boolean LevelDiscountsApplyToExtendedPrices { get; set; }
        public string LastIPAddress { get; set; }
        public string PaymentMethod { get; set; }
        public string OrderNotes { get; set; }
        public string PONumber { get; set; }
        public DateTime DownloadEmailSentOn { get; set; }
        public DateTime ReceiptEmailSentOn { get; set; }
        public DateTime DistributorEmailSentOn { get; set; }
        public string ShippingTrackingNumber { get; set; }
        public string ShippedVIA { get; set; }
        public string CustomerServiceNotes { get; set; }
        public string RTShipRequest { get; set; }
        public string RTShipResponse { get; set; }
        public string TransactionState { get; set; }
        public string AVSResult { get; set; }
        public string CaptureTXCommand { get; set; }
        public string CaptureTXResult { get; set; }
        public string VoidTXCommand { get; set; }
        public string VoidTXResult { get; set; }
        public string RefundTXCommand { get; set; }
        public string RefundTXResult { get; set; }
        public string RefundReason { get; set; }
        public string CardinalLookupResult { get; set; }
        public string CardinalAuthenticateResult { get; set; }
        public string CardinalGatewayParms { get; set; }
        public string OrderOptions { get; set; }
        public double OrderWeight { get; set; }
        public string eCheckBankABACode { get; set; }
        public string eCheckBankAccountNumber { get; set; }
        public string eCheckBankAccountType { get; set; }
        public string eCheckBankName { get; set; }
        public string eCheckBankAccountName { get; set; }
        public string CarrierReportedRate { get; set; }
        public string CarrierReportedWeight { get; set; }
        public string LocaleSetting { get; set; }
        public string FinalizationData { get; set; }
        public string ExtensionData { get; set; }
        public Boolean AlreadyConfirmed { get; set; }
        public int CartType { get; set; }
        public char[] THUB_POSTED_TO_ACCOUNTING { get; set; }
        public DateTime THUB_POSTED_DATE { get; set; }
        public string THUB_ACCOUNTING_REF { get; set; }
        public string Last4 { get; set; }
        public Boolean ReadyToShip { get; set; }
        public Boolean IsPrinted { get; set; }
        public DateTime AuthorizedOn { get; set; }
        public DateTime CapturedOn { get; set; }
        public DateTime RefundedOn { get; set; }
        public DateTime VoidedOn { get; set; }
        public DateTime FraudedOn { get; set; }
        public DateTime EditedOn { get; set; }
        public string TrackingURL { get; set; }
        public DateTime ShippedEMailSentOn { get; set; }
        public int InventoryWasReduced { get; set; }
        public double MaxMindFraudScore { get; set; }
        public string MaxMindDetails { get; set; }
        public string VATRegistrationId { get; set; }
        public int Crypt { get; set; }
        public int TransactionType { get; set; }
        public string RecurringSubscriptionId { get; set; }
        public string RecurringSubscriptionCommand { get; set; }
        public string RecurringSubscriptionResult { get; set; }
        public int RelatedOrderNumber { get; set; }
        public string BuySafeCommand { get; set; }
        public string BuySafeResult { get; set; }
        #endregion

        #region ctor
        public Orders()
        {
            OrderId = Guid.NewGuid();
        }

        public Orders(Guid orderId)
        {
            OrderId = orderId;
        }
        #endregion
    }
}
