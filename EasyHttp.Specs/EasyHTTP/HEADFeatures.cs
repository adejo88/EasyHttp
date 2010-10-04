﻿using Machine.Specifications;

namespace EasyHttp.Specs.EasyHTTP
{


    [Subject("Working with HEAD")]
    public class when_requesting_a_head_for_valid_uri
    {
        Establish context = () =>
        {
            _easyHttp = new EasyHttp();
        };

        Because of = () =>
        {
            _easyHttp.Head("http://localhost:5984");
            response = _easyHttp.Response;

        };

        It should_return_correct_header =
            () => response.Header.StatusDescription.ShouldEqual("OK");

        static EasyHttp _easyHttp;
        static Response response;
    }

   
}
