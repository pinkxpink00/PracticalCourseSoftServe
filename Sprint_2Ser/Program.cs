using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

class Student
{
	public string Name { get; set; }
	public double Rating { get; set; }
	public string GroupName { get; set; }
}

class Group
{
	public string Name { get; set; }
	public string Description { get; set; }
	public int Popularity { get; set; }
}

class Program
{
	public static string CreateGroups(List<Student> students, List<Group> groups)
	{
		var groupInfo = groups.GroupJoin(
			students,
			group => group.Name,
			student => student.GroupName,
			(group, studentsInGroup) => new
			{
				group.Name,
				group.Description,
				Rating = studentsInGroup.Average(student => student.Rating),
				Students = studentsInGroup.Select(student => new
				{
					FullName = student.Name,
					AvgMark = student.Rating
				})
			}
		);

		JsonSerializerOptions options = new JsonSerializerOptions
		{
			WriteIndented = true,
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
		};
		return JsonSerializer.Serialize(groupInfo, options);
	}

	static void Main()
	{
		List<Student> students = new List<Student>
		{
			new Student { Name = "Ivan", Rating = 68.34, GroupName = "Group A" },
			new Student { Name = "Oleh", Rating = 98.34, GroupName = "Group A" },
			new Student { Name = "Katya", Rating = 88.34, GroupName = "Group B" }
		};

		List<Group> groups = new List<Group>
		{
			new Group { Name = "Group A", Description = "Description A", Popularity = 100 },
			new Group { Name = "Group B", Description = "Description B", Popularity = 150 }
		};

		string result = CreateGroups(students, groups);
		Console.WriteLine(result);
	}
}
