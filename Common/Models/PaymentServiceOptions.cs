using Ipp.Recruitment.Common.Contracts;

namespace Ipp.Recruitment.Common.Models
{
	/// <summary>
	/// The payment service options
	/// </summary>
	public class PaymentServiceOptions : IPaymentServiceOptions
	{
		public string CandidateId { get; set; }
	}
}
