using Ipp.Recruitment.Common.Contracts;
using System;

namespace Ipp.Recruitment.BusinessLogic
{
	public class PaymentService : IPaymentService
	{
		/// <summary>
		/// Payment service options
		/// </summary>
		private IPaymentServiceOptions _paymentServiceOptions;

		/// <summary>
		/// Create an instance of PaymentService based on the PaymentServiceOptions
		/// </summary>
		/// <param name="paymentServiceOptions"></param>
		public PaymentService(IPaymentServiceOptions paymentServiceOptions)
		{
			if (paymentServiceOptions == null)
			{
				throw new ArgumentNullException("paymentServiceOptions");
			}
			_paymentServiceOptions = paymentServiceOptions;
		}

		/// <summary>
		/// Returns the unique ID allocated to a candidate
		/// </summary>
		public string WhatsYourId()
		{
			return _paymentServiceOptions.CandidateId;
		}

		public bool CanMakePaymentWithCard(string cardNumber, int expiryMonth, int expiryYear)
		{
			throw new NotImplementedException();
		}

		public bool IsCardNumberValid(string cardNumber)
		{
			throw new NotImplementedException();
		}

		public bool IsValidPaymentAmount(long amount)
		{
			throw new NotImplementedException();
		}
	}
}
