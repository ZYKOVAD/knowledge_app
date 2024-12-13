﻿using System;
using System.Collections.Generic;

namespace knowledge_app;

public partial class Discipline
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
