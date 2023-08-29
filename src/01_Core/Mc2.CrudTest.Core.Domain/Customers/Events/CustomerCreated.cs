﻿using Framework.Core.Domain.Events;

namespace Mc2.CrudTest.Core.Domain.Customers.Events;

public record CustomerCreated(Guid BusinessId,
                              string FirstName,
                              string LastName,
                              DateTime DateOfBirth,
                              string PhoneNumber,
                              string Email,
                              string BankAccountNumber) : IDomainEvent;
