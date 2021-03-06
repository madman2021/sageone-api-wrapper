﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class CustomerTests : TestBase
	{
		[TestMethod]
		public void GetAllCustomers()
		{
			var customers = Api.CustomerRequest.Get();
		}

		[TestMethod]
		public void GetCustomer()
		{
			int customerId = 0;
			var customer = Api.CustomerRequest.Get(customerId);
		}

		[TestMethod]
		public void SaveCustomer()
		{
			var customer = new Customer
			{
				Name = "Mr. David R. Robinett",
				AcceptsElectronicInvoices = true,
				Active = true,
				AutoAllocateToOldestInvoice = true,
				ContactName = "Mr. David R. Robinett",
				DeliveryAddress01 = "Pappelallee 6667",
				DeliveryAddress02 = "Solingen",
				DeliveryAddress03 = "Nordrhein-Westfalen",
				DeliveryAddress04 = "42651",
				DeliveryAddress05 = "Germany",
				CommunicationMethod = 1,
				PostalAddress01 = "Pappelallee 6667",
				PostalAddress02 = "Solingen",
				PostalAddress03 = "Nordrhein-Westfalen",
				PostalAddress04 = "42651",
				PostalAddress05 = "Germany",
				Telephone = "238-555-0100",
				SalesRepresentativeId = null
			};
            Api.CustomerRequest.Save(customer);
		}

		[TestMethod]
		public void DeleteCustomer()
		{
			int customerId = 0;
			var result = Api.CustomerRequest.Delete(customerId);
		}
	}
}
