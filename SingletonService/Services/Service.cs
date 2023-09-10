namespace SingletonService.Services
{
    public class Service : IService
    {
        private string PolicyNumber;

        public string GetPolicyNumber()
        {
            return PolicyNumber;
        }

        public void SetPolicyNumber(string policyNumber)
        {
            PolicyNumber = policyNumber;
        }
    }
}
