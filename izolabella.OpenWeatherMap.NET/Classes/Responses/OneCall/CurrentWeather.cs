﻿using izolabella.OpenWeatherMap.NET.Classes.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.OpenWeatherMap.NET.Classes.Responses.OneCall
{
    /// <summary>
    /// A class containing relevant information in regards to the OneCall API in OpenWeatherMap.
    /// </summary>
    public class CurrentWeather
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentWeather"/> class.
        /// </summary>
        public CurrentWeather(ulong CurrentTime, ulong Sunset, ulong Sunrise, decimal Temperature, decimal FeelsLike,
                              int AtmosphericPressure, decimal Humidity, decimal DewPoint, decimal Cloudiness,
                              decimal UVI, decimal Visibility, decimal WindSpeed, decimal? WindGust, Weather[] Weather)
        {
            this.currentTime = CurrentTime;
            this.sunset = Sunset;
            this.sunrise = Sunrise;
            this.Temperature = Temperature;
            this.FeelsLike = FeelsLike;
            this.AtmosphericPressure = AtmosphericPressure;
            this.humidity = Humidity;
            this.DewPoint = DewPoint;
            this.cloudiness = Cloudiness;
            this.UVI = UVI;
            this.Visibility = Visibility;
            this.WindSpeed = WindSpeed;
            this.WindGust = WindGust;
            this.Weather = Weather;
        }

        [JsonProperty("dt")]
        private readonly ulong currentTime;
        /// <summary>
        /// The current time in UTC.
        /// </summary>
        public DateTime CurrentTime => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.currentTime).ToUniversalTime();

        [JsonProperty("sunset")]
        private readonly ulong sunset;
        /// <summary>
        /// The time the sun sets in UTC.
        /// </summary>
        public DateTime Sunset => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.sunset).ToUniversalTime();

        [JsonProperty("sunrise")]
        private readonly ulong sunrise;
        /// <summary>
        /// The time the sun rises in UTC.
        /// </summary>
        public DateTime Sunrise => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.sunrise).ToUniversalTime();

        /// <summary>
        /// The current temperature.
        /// </summary>
        [JsonProperty("temp")]
        public decimal Temperature { get; }

        /// <summary>
        /// The human perception of the current temperature.
        /// </summary>
        [JsonProperty("feels_like")]
        public decimal FeelsLike { get; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa.
        /// </summary>
        [JsonProperty("pressure")]
        public int AtmosphericPressure { get; }

        [JsonProperty("humidity")]
        private readonly decimal humidity;
        /// <summary>
        /// The current humidity as a decimal ranging from 0 - 1.
        /// </summary>
        public decimal Humidity => this.humidity / 100;

        /// <summary>
        /// Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form.
        /// </summary>
        [JsonProperty("dew_point")]
        public decimal DewPoint { get; }

        [JsonProperty("clouds")]
        private readonly decimal cloudiness;
        /// <summary>
        /// The current cloudiness as a decimal ranging from 0 - 1.
        /// </summary>
        public decimal Cloudiness => this.cloudiness / 100;

        /// <summary>
        /// Current UV index.
        /// </summary>
        [JsonProperty("uvi")]
        public decimal UVI { get; }

        /// <summary>
        /// The current visibility average in metres.
        /// </summary>
        [JsonProperty("visibility")]
        public decimal Visibility { get; }

        /// <summary>
        /// Wind speed. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
        /// </summary>
        [JsonProperty("wind_speed")]
        public decimal WindSpeed { get; }

        /// <summary>
        /// Wind gust. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.
        /// </summary>
        [JsonProperty("wind_gust")]
        public decimal? WindGust { get; }

        /// <summary>
        /// Group of weather parameters.
        /// </summary>
        [JsonProperty("weather")]
        public Weather[] Weather { get; }
    }
}
