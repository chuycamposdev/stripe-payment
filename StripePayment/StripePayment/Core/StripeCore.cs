

using Stripe;

namespace StripePayment.Core
{
    public class StripeCore
    {
        public StripeClient _stripeClientV2 { get; private set; }

        public StripeCore(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException("API key must be provided", nameof(apiKey));

            _stripeClientV2 = new StripeClient(apiKey);
        }
    }
}
