﻿using TheTachkuNaProkachkuConctrat.Exceptions;
using TheTachkuNaProkachkuConctrat.Enums;
using TheTachkuNaProkachkuConctrat.Extensions;
using TheTachkuNaProkachkuConctrat.Infrastructure;

namespace TheTachkuNaProkachkuConctrat.DataModels;

public class PostDataModel(string id, string postId, string postName, PostType postType, double salary, bool isActual, DateTime changeDate) : IValidation
{
    public string Id { get; private set; } = id;

    public string PostId { get; private set; } = postId;

    public string PostName { get; private set; } = postName;

    public PostType PostType { get; private set; } = postType;

    public double Salary { get; private set; } = salary;

    public bool IsActual { get; private set; } = isActual;

    public DateTime ChangeDate { get; private set; } = changeDate;

    public void Validate()
    {
        if (Id.IsEmpty())
            throw new ValidationException("Field Id is empty");

        if (!Id.IsGuid())
            throw new ValidationException("The value in the field Id is not a unique identifier");

        if (PostId.IsEmpty())
            throw new ValidationException("Field PostId is empty");

        if (!PostId.IsGuid())
            throw new ValidationException("The value in the field PostId is not a unique identifier");

        if (PostName.IsEmpty())
            throw new ValidationException("Field PostName is empty");

        if (PostType == PostType.None)
            throw new ValidationException("Field PostType is empty");

        if (Salary <= 0)
            throw new ValidationException("Field Salary is empty");
    }
}
