﻿using System;

namespace BitPaySDK.Exceptions
{
    public class BillException : BitPayException
    {
        private const string BitPayMessage = "An unexpected error occured while trying to manage the bill";
        private readonly string _bitpayCode = "BITPAY-BILL-GENERIC";
        protected string ApiCode;

        public BillException() : base(BitPayMessage)
        {
            BitpayCode = _bitpayCode;
        }

        public BillException(Exception ex) : base(BitPayMessage, ex)
        {
            BitpayCode = _bitpayCode;
        }

        public BillException(string bitpayCode, string message) : base(bitpayCode, message)
        {
        }

        public BillException(string bitpayCode, string message, Exception cause, string apiCode = "000000") : base(bitpayCode, message, cause, apiCode)
        {
            ApiCode = apiCode;
        }

        public String GetApiCode()
        {
            return ApiCode;
        }
    }
}