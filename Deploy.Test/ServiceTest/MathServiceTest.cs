using Microsoft.Extensions.DependencyInjection;
using Ubuntu_Deploy.Services;

namespace Deploy.Test.ServiceTest
{
    public class MathServiceTest
    {
        private readonly ServiceProvider services;
        public MathServiceTest()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IMathService, MathService>();

            this.services = serviceCollection.BuildServiceProvider();
        }

        [Fact]
        public async Task ShoulAddTwoNumbersCorrectly()
        {
            var mathService = services.GetRequiredService<IMathService>();
            var a = 3;
            var b = 7;

            var result = await mathService.AddAsync(a, b, CancellationToken.None);

            Assert.Equal(10, result);
        }
    }
}
