using System;
using System.Threading.Tasks;

namespace CaseStudy.Service
{
    public class CountService
    {
        public async Task<int> GetUserCountAsync()
        {
            Random random = new Random();
            return random.Next(100, 1000);
        }

        public async Task<int> GetOrderCountAsync()
        {
            Random random = new Random();
            return random.Next(50, 500);
        }

        public async Task<int> GetProductCountAsync()
        {
            Random random = new Random();
            return random.Next(200, 2000);
        }
    }
}