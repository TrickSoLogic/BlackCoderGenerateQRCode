using System.ComponentModel.DataAnnotations;

namespace BlackCoderGenerateQRCode.Models
{
    public class GenerateQRCodeModel
    {
        [Display(Name ="Enter QR Code Text")]
        public string QRCodeText { get; set; }
    }
}
