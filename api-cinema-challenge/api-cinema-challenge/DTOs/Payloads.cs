﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace api_cinema_challenge.DTOs
{
    public record CreateCustomerPayload {

        [Required(ErrorMessage = "Name required!")]
        public string Name { get; init; }

        [Required(ErrorMessage = "Email required!")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Phone number required!")]
        public string Phone { get; init; }

        public CreateCustomerPayload(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

    };


    public record CreateTicketPayload
    {

        [Required(ErrorMessage = "Seats are required!")]
        public int numSeats { get; init; }

        public CreateTicketPayload(int NumSeats)
        {
            numSeats = NumSeats;
        }

    };


    public record CreateScreeningPayload
    {

        [Required(ErrorMessage = "Screen Number Required!")]
        [JsonPropertyName("screenNumber")]
        public int screenNumber { get; init; }

        [Required(ErrorMessage = "Capacity Required!")]
        [JsonPropertyName("capacity")]
        public int capacity { get; init; }

        [Required(ErrorMessage = "Starting Datetime Required!")]
        [JsonPropertyName("startsAt")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "YYYY-MM-DD HH:MM:SS")] // why doesn't it work... does the static method lack the model context?
        public string startsAt { get; init; }

        public CreateScreeningPayload(int ScreenNumber, int Capacity, string StartsAt )
        {
            screenNumber = ScreenNumber;
            capacity = Capacity;
            startsAt = StartsAt;
        }
    };
    

    public record CreateMoviePayload {


        [Required(ErrorMessage = "Field required!")]
        public string title { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public string rating { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public string description { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public int runtimeMins { get; init; }

        public List<CreateScreeningPayload>? Screenings { get; init; } = new List<CreateScreeningPayload>();

        public CreateMoviePayload(string Title, string Rating, string Description, int RuntimeMins, List<CreateScreeningPayload>? screenings)
        {
            title = Title;
            rating = Rating;
            description = Description;
            runtimeMins = RuntimeMins;
            Screenings = screenings;
        }
    };



    public record UpdateCustomerPayload
    {

        [Required(ErrorMessage = "Name required!")]
        public string name { get; init; }

        [Required(ErrorMessage = "Email required!")]
        public string email { get; init; }

        [Required(ErrorMessage = "Phone number required!")]
        public string phone { get; init; }

        public UpdateCustomerPayload(string Name, string Email, string Phone)
        {
            name = Name;
            email = Email;
            phone = Phone;
        }

    };

    public record UpdateMoviePayload
    {


        [Required(ErrorMessage = "Field required!")]
        public string title { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public string rating { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public string description { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public int runtimeMins { get; init; }

        public UpdateMoviePayload(string Title, string Rating, string Description, int RuntimeMins)
        {
            title = Title;
            rating = Rating;
            description = Description;
            runtimeMins = RuntimeMins;
        }

    };

}

