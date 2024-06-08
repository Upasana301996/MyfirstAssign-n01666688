using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstAssign_n01666688.Controllers
{
    public class GreetingController : ApiController
    {

        /// <summary>
        /// This method lostens to a post request and provides a string response
        /// </summary>
        /// <returns>
        /// "Hello World!"
        /// </returns>
        /// <Question>
        /// POST: localhost/api/Greeting -> "Hello World!" 
        /// POST: localhost/Greeting
        /// curl -d "" http://localhost:53090/api/Greeting
        /// </Question>
        public string Post()
        {
            string response = "Hello World!";
            return response;
        }





        /// <summary>
        /// Receive input and returns value
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// "Greetings to {input} people!"
        /// </returns>
        /// <question>
        /// Returns the string “Greetings to {id} people!” where id is an integer value.
        /// GET localhost/Greeting/3
        /// GET localhost/Greeting/6
        /// GET localhost/Greeting/0
        /// </question>



        public string Get(int id)
        {
            string output = "Greeting to" + id + "people!";
            return output;

        }

    }

}