using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenWeatherApiTests
{
    [Binding]
    public class OneCallRequestSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public OneCallRequestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I make a OneCall Request to get the Weather for '(.*)'")]
        public void WhenIMakeAOneCallRequestToGetTheWeatherForCity(string city)
        {
            string apiKey = "appid=" + TestDataUtils.getApiKey();
            string latitude = "lat=" + TestDataUtils.getCityLatitude(city);
            string longitude = "lon=" + TestDataUtils.getCityLongitude(city);
            var url = TestDataUtils.baseUrl + TestDataUtils.oneCallApi + latitude + "&" + longitude + "&" + apiKey;

            _scenarioContext["response"] = RequestUtils.GetRequest(url).Result;
        }
        
        [Then(@"I receive the expected Weather Report for '(.*)'")]
        public void ThenIReceiveTheExpectedWeatherReportForCity(string city)
        {
            string response = _scenarioContext["response"].ToString();
            string timezone = JsonUtils.getFieldFromJson(response, "timezone");
            Assert.AreEqual(TestDataUtils.getCityTimezone(city), timezone, true);
        }
        
        [Then(@"I am able to find the Hottest Day within the Response")]
        public void ThenIAmAbleToFindTheHottestDayWithinTheResponse()
        {
            string response = _scenarioContext["response"].ToString();
            string dailyForecast = JsonUtils.getFieldFromJson(response, "daily");
            List<string> temperatureList = JsonUtils.getListFromJsonByField(dailyForecast, "temp");

            List<string> dayTemperatureList = new List<string>();
            temperatureList.ForEach(temperatures => dayTemperatureList.Add(JsonUtils.getFieldFromJson(temperatures, "day")));

            dayTemperatureList.ForEach(dayTemperature => Assert.AreNotEqual("", dayTemperature));
        }

        [Then(@"I am able to find the minimum and maximum temperature for the current day")]
        public void ThenIAmAbleToFindTheMinimumAndMaximumTemperatureForTheCurrentDay()
        {
            string response = _scenarioContext["response"].ToString();
            string hourlyForecast = JsonUtils.getFieldFromJson(response, "hourly");
            List<string> temperatureList = JsonUtils.getListFromJsonByField(hourlyForecast, "temp");

            temperatureList.ForEach(temperature => Assert.AreNotEqual("", temperature));
        }
    }
}
