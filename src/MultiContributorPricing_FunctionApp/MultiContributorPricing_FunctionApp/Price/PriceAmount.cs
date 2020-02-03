using System;
using System.Collections.Generic;
using System.Text;

namespace MultiContributorPricing_FunctionApp.Price
{
    public class PriceAmount
    {

        /// <summary>
        /// ISO 3 letter currency code in which the priced item is priced
        /// </summary>
        string CurrencyCode { get; set; }

        /// <summary>
        /// The amnount in the priced currency
        /// </summary>
        decimal Amount { get; set; }

    }
}
