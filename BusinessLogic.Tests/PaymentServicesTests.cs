using Ipp.Recruitment.BusinessLogic;
using Ipp.Recruitment.Common.Contracts;
using Ipp.Recruitment.Common.Models;
using Xunit;

namespace BusinessLogic.Tests
{
	public class PaymentServicesTests
	{
		private static IPaymentServiceOptions paymentServiceOptions = new PaymentServiceOptions { CandidateId = "123456" } ;
		private static IPaymentService paymentService = new PaymentService(paymentServiceOptions);

		[Fact]
		public void WhatsYourId_ShouldReturnTheId()
		{
			var id = paymentService.WhatsYourId();
			Assert.NotNull(id);
		}
	}
}
