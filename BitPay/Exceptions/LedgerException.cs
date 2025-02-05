﻿using System;

namespace BitPaySDK.Exceptions
{
    public class LedgerException : BitPayException
    {
        private const string BitPayMessage = "An unexpected error occured while trying to manage the ledger";
        private readonly string _bitpayCode = "BITPAY-LEDGER-GENERIC";
        protected string ApiCode;

        public LedgerException() : base(BitPayMessage)
        {
            BitpayCode = _bitpayCode;
        }

        public LedgerException(Exception ex) : base(BitPayMessage, ex)
        {
            BitpayCode = _bitpayCode;
        }

        public LedgerException(string bitpayCode, string message) : base(bitpayCode, message)
        {
        }

        public LedgerException(string bitpayCode, string message, Exception cause, string apiCode = "000000") : base(bitpayCode, message, cause, apiCode)
        {
            ApiCode = apiCode;
        }

        public String GetApiCode()
        {
            return ApiCode;
        }
    }
}