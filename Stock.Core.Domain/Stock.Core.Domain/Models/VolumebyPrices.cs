//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stock.Core.Domain.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VolumebyPrices
    {
        public int VolumeByPriceID { get; set; }
        public decimal DailyQuotesID { get; set; }
        public float Price { get; set; }
        public int Volume { get; set; }
        public float Percentage { get; set; }
        public byte BidOrAsk { get; set; }
    
        public virtual DailyQuotes DailyQuotes { get; set; }
    }
}
