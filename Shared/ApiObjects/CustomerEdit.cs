﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithFluxorStateManagement.Shared.ApiObjects;
public class CustomerEdit
{
    public int Id { get; set; } = 42;
    public byte[] RowVersion { get; set; } = Array.Empty<byte>();
    public string Name { get; set; }

    public CustomerEdit() { }
    public CustomerEdit(int id, byte[] rowVersion, string name)
    {
        Id = id;
        RowVersion = rowVersion;
        Name = name;
    }
}