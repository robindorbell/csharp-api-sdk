﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5466
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using FortnoxAPILibrary.Connectors;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 

namespace FortnoxAPILibrary
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SupplierInvoice
    {

        private string administrationFeeField;

        private string balanceField;

        private string bookedField;

        private string cancelledField;

        private string commentsField;

        private string creditField;

        private string creditReferenceField;

        private string currencyField;

        private string currencyRateField;

        private string currencyUnitField;

        private string disablePaymentFileField;

        private string dueDateField;

        private string externalInvoiceNumberField;

        private string externalInvoiceSeriesField;

        private string freightField;

        private string voucherSeriesField;

        private string voucherNumberField;

        private string voucherYearField;

        private string givenNumberField;

        private string invoiceDateField;

        private string invoiceNumberField;

        private string oCRField;

        private string roundOffValueField;

        private SupplierInvoiceConnector.SalesType salesTypeField;

        private string supplierNumberField;

        private string supplierNameField;

        private string totalField;

        private string vATField;

        private SupplierInvoiceConnector.VATType vATTypeField;

        private List<SupplierInvoiceRow> supplierInvoiceRowsField;

        private string urlField;

        /// <remarks/>
        public SupplierInvoice()
        {
            this.SupplierInvoiceRows = new List<SupplierInvoiceRow>();
        }

        /// <remarks/>
        public string AdministrationFee
        {
            get
            {
                return this.administrationFeeField;
            }
            set
            {
                this.administrationFeeField = value;
            }
        }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        public string Balance
        {
            get
            {
                return this.balanceField;
            }
            set
            {
                this.balanceField = value;
            }
        }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        public string Booked
        {
            get
            {
                return this.bookedField;
            }
            set
            {
                this.bookedField = value;
            }
        }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        public string Cancelled
        {
            get
            {
                return this.cancelledField;
            }
            set
            {
                this.cancelledField = value;
            }
        }

        /// <remarks/>
        public string Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        public string Credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        public string CreditReference
        {
            get
            {
                return this.creditReferenceField;
            }
            set
            {
                this.creditReferenceField = value;
            }
        }

        /// <remarks/>
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public string CurrencyRate
        {
            get
            {
                return this.currencyRateField;
            }
            set
            {
                this.currencyRateField = value;
            }
        }

        /// <remarks/>
        public string CurrencyUnit
        {
            get
            {
                return this.currencyUnitField;
            }
            set
            {
                this.currencyUnitField = value;
            }
        }

        /// <remarks/>
        public string DisablePaymentFile
        {
            get
            {
                return this.disablePaymentFileField;
            }
            set
            {
                this.disablePaymentFileField = value;
            }
        }

        /// <remarks/>
        public string DueDate
        {
            get
            {
                return this.dueDateField;
            }
            set
            {
                this.dueDateField = value;
            }
        }

        /// <remarks/>
        public string ExternalInvoiceNumber
        {
            get
            {
                return this.externalInvoiceNumberField;
            }
            set
            {
                this.externalInvoiceNumberField = value;
            }
        }

        /// <remarks/>
        public string ExternalInvoiceSeries
        {
            get
            {
                return this.externalInvoiceSeriesField;
            }
            set
            {
                this.externalInvoiceSeriesField = value;
            }
        }

        /// <remarks/>
        public string Freight
        {
            get
            {
                return this.freightField;
            }
            set
            {
                this.freightField = value;
            }
        }

        /// <remarks/>
        public string VoucherSeries
        {
            get
            {
                return this.voucherSeriesField;
            }
            set
            {
                this.voucherSeriesField = value;
            }
        }

        /// <remarks/>
        public string VoucherNumber
        {
            get
            {
                return this.voucherNumberField;
            }
            set
            {
                this.voucherNumberField = value;
            }
        }

        /// <remarks/>
        public string VoucherYear
        {
            get
            {
                return this.voucherYearField;
            }
            set
            {
                this.voucherYearField = value;
            }
        }

        /// <remarks/>
        public string GivenNumber
        {
            get
            {
                return this.givenNumberField;
            }
            set
            {
                this.givenNumberField = value;
            }
        }

        /// <remarks/>
        public string InvoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }

        /// <remarks/>
        public string InvoiceNumber
        {
            get
            {
                return this.invoiceNumberField;
            }
            set
            {
                this.invoiceNumberField = value;
            }
        }

        /// <remarks/>
        public string OCR
        {
            get
            {
                return this.oCRField;
            }
            set
            {
                this.oCRField = value;
            }
        }


        /// <remarks/>
        public string RoundOffValue
        {
            get
            {
                return this.roundOffValueField;
            }
            set
            {
                this.roundOffValueField = value;
            }
        }

        /// <remarks/>
        public SupplierInvoiceConnector.SalesType SalesType
        {
            get
            {
                return this.salesTypeField;
            }
            set
            {
                this.salesTypeField = value;
            }
        }

        /// <remarks/>
        public string SupplierNumber
        {
            get
            {
                return this.supplierNumberField;
            }
            set
            {
                this.supplierNumberField = value;
            }
        }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        public string SupplierName
        {
            get
            {
                return this.supplierNameField;
            }
            set
            {
                this.supplierNameField = value;
            }
        }

        /// <remarks/>
        public string Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public string VAT
        {
            get
            {
                return this.vATField;
            }
            set
            {
                this.vATField = value;
            }
        }

        /// <remarks/>
        public SupplierInvoiceConnector.VATType VATType
        {
            get
            {
                return this.vATTypeField;
            }
            set
            {
                this.vATTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SupplierInvoiceRow", typeof(SupplierInvoiceRow), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<SupplierInvoiceRow> SupplierInvoiceRows
        {
            get
            {
                return this.supplierInvoiceRowsField;
            }
            set
            {
                this.supplierInvoiceRowsField = value;
            }
        }

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SupplierInvoiceRow
    {

        private string accountField;

        private string articleNumberField;

        private string codeField;

        private string costCenterField;

        private string projectField;

        private string transactionInformationField;

        private string itemDescriptionField;

        private string accountDescriptionField;

        private string priceField;

        private string quantityField;

        private string totalField;

        private string creditField;

        private string debitField;

        private string creditCurrencyField;

        private string debitCurrencyField;

        private string unitField;

        /// <remarks/>
        public string Account
        {
            get
            {
                return this.accountField;
            }
            set
            {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public string ArticleNumber
        {
            get
            {
                return this.articleNumberField;
            }
            set
            {
                this.articleNumberField = value;
            }
        }

        /// <remarks/>
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string CostCenter
        {
            get
            {
                return this.costCenterField;
            }
            set
            {
                this.costCenterField = value;
            }
        }

        /// <remarks/>
        public string Project
        {
            get
            {
                return this.projectField;
            }
            set
            {
                this.projectField = value;
            }
        }

        /// <remarks/>
        public string TransactionInformation
        {
            get
            {
                return this.transactionInformationField;
            }
            set
            {
                this.transactionInformationField = value;
            }
        }

        /// <remarks/>
        public string ItemDescription
        {
            get
            {
                return this.itemDescriptionField;
            }
            set
            {
                this.itemDescriptionField = value;
            }
        }

        /// <remarks />
        public string AccountDescription
        {
            get
            {
                return this.accountDescriptionField;
            }
            set
            {
                this.accountDescriptionField = value;
            }
        }

        /// <remarks/>
        public string Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public string Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public string Credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <remarks/>
        public string Debit
        {
            get
            {
                return this.debitField;
            }
            set
            {
                this.debitField = value;
            }
        }

        /// <remarks/>
        public string CreditCurrency
        {
            get
            {
                return this.creditCurrencyField;
            }
            set
            {
                this.creditCurrencyField = value;
            }
        }

        /// <remarks/>
        public string DebitCurrency
        {
            get
            {
                return this.debitCurrencyField;
            }
            set
            {
                this.debitCurrencyField = value;
            }
        }

        /// <remarks/>
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }
}