﻿namespace Digipix.Infrastructure.Service.Constants
{
    public static class EndPoints
    {
        public static string JWTToken { get { return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhdWQiOiJkZXNmaW8uZm90b3JlZ2lzdHJvLmNvbS5iciIsImV4cCI6MTU3NzU1NDEzMywianRpIjoiNzBlODRlZmQtMGRmNC00ZmZhLTlmYTYtNTI1M2ZjNmFmMDgyIiwiaWF0IjoxNTQ2NDUwMTMzLCJpc3MiOiJodHRwczovL3NlcnZpY2UtaG9tb2xvZy5kaWdpcGl4LmNvbS5iciIsInN0b3JlSWQiOjc5LCJzdG9yZU5hbWUiOiJGb3RvcmVnaXN0cm8iLCJzdG9yZVVSTCI6ImRlc2Zpby5mb3RvcmVnaXN0cm8uY29tLmJyIn0.yPFKdRdc4jTAUuziqfkvJm74W5axDelkaH-Q6lBTE8k"; } }


        public static string URL { get { return "https://service-homolog.digipix.com.br/v0b"; } }


        public static string Get { get { return URL + "/shipments/zipcode/"; } }
    }
}
