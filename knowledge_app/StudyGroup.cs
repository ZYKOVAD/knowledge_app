using System;
using System.Collections.Generic;

namespace knowledge_app;

public partial class StudyGroup
{
    public int Id { get; set; }

    public string GroupNumber { get; set; } = null!;

    public int? StudyProgramId { get; set; }

    public virtual StudyProgram? StudyProgram { get; set; }
}
