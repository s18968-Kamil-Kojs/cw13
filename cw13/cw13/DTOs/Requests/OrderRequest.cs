using System;
using System.Collections.Generic;

namespace cw13.DTOs.Requests {

    public class OrderRequest {
        public string dataPrzyjecia { get; set; }
        public string uwagi { get; set; }
        public List<WyrobRequest> wyroby { get; set; }

        public OrderRequest() {
        }
    }
}
