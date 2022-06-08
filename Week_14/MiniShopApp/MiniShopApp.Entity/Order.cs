﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PaymentId { get; set; }
        public string ConversationId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public EnumOrderState OrderState { get; set; }
        public EnumPaymentType PaymentType { get; set; }
    }

    public enum EnumOrderState
    {
        Waiting=0,
        Unpaint=1,
        Completed=2
    }
    public enum EnumPaymentType
    {
        CreditCard=0,
        Eft=1
    }
}
