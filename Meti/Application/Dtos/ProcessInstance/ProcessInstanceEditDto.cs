﻿//Concesso in licenza a norma dell'EUPL, versione 1.2. 2019

//Concesso in licenza a norma dell'EUPL, versione 1.2
using MateSharp.Framework.Dtos;
using Meti.Application.Dtos.Process;
using Meti.Application.Dtos.Registry;
using Meti.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Meti.Application.Dtos.ProcessInstance
{
    public class ProcessInstanceEditDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public Guid? Patient { get; set; }
        public ProcessEditDto Process { get; set; }
        public IList<RegistryEditDto> Doctors { get; set; }
        public IList<RegistryEditDto> ReferencePersons { get; set; }
        public ItemDto<ProcessInstanceState?> ProcessInstanceState { get; set; }
        public DateTime? ReOpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string ReOpenFrom {get; set;}
        public string CloseFrom { get; set; }
    }
}