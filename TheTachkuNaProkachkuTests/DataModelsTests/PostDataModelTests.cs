﻿using TheTachkuNaProkachkuConctrat.Exceptions;
using TheTachkuNaProkachkuConctrat.DataModels;
using TheTachkuNaProkachkuConctrat.Enums;

namespace TheTachkuNaProkachkuTests.DataModelsTests;

[TestFixture]
internal class PostDataModelTests
{
    [Test]
    public void IdIsNullOrEmptyTest()
    {
        var post = CreateDataModel(null, Guid.NewGuid().ToString(), "name", PostType.Assistant, 10, true, DateTime.UtcNow);
        Assert.That(() => post.Validate(), Throws.TypeOf<ValidationException>());
        post = CreateDataModel(string.Empty, Guid.NewGuid().ToString(), "name", PostType.Assistant, 10, true, DateTime.UtcNow);
        Assert.That(() => post.Validate(), Throws.TypeOf<ValidationException>());
    }

    [Test]
    public void IdIsNotGuidTest()
    {
        var post = CreateDataModel("id", Guid.NewGuid().ToString(), "name", PostType.Assistant, 10, true, DateTime.UtcNow);
        Assert.That(() => post.Validate(), Throws.TypeOf<ValidationException>());
    }

    [Test]
    public void PostIdIsNullEmptyTest()
    {
        var post = CreateDataModel(Guid.NewGuid().ToString(), null, "name", PostType.Assistant, 10, true, DateTime.UtcNow);
        Assert.That(() => post.Validate(), Throws.TypeOf<ValidationException>());
        post = CreateDataModel(Guid.NewGuid().ToString(), string.Empty, "name", PostType.Assistant, 10, true, DateTime.UtcNow);
        Assert.That(() => post.Validate(), Throws.TypeOf<ValidationException>());
    }

    [Test]
    public void PostIdIsNotGuidTest()
    {
        var post = CreateDataModel(Guid.NewGuid().ToString(), "postId", "name", PostType.Assistant, 10, true, DateTime.UtcNow);
        Assert.That(() => post.Validate(), Throws.TypeOf<ValidationException>());
    }

    [Test]
    public void PostNameIsEmptyTest()
    {
        var manufacturer = CreateDataModel(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), null, PostType.Assistant, 10, true, DateTime.UtcNow);
        Assert.That(() => manufacturer.Validate(), Throws.TypeOf<ValidationException>());
        manufacturer = CreateDataModel(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), string.Empty, PostType.Assistant, 10, true, DateTime.UtcNow);
        Assert.That(() => manufacturer.Validate(), Throws.TypeOf<ValidationException>());
    }

    [Test]
    public void PostTypeIsNoneTest()
    {
        var post = CreateDataModel(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), "name", PostType.None, 10, true, DateTime.UtcNow);
        Assert.That(() => post.Validate(), Throws.TypeOf<ValidationException>());
    }

    [Test]
    public void SalaryIsLessOrZeroTest()
    {
        var post = CreateDataModel(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), "name", PostType.Assistant, 0, true, DateTime.UtcNow);
        Assert.That(() => post.Validate(), Throws.TypeOf<ValidationException>());
        post = CreateDataModel(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), "name", PostType.Assistant, -10, true, DateTime.UtcNow);
        Assert.That(() => post.Validate(), Throws.TypeOf<ValidationException>());
    }

    [Test]
    public void AllFieldsIsCorrectTest()
    {
        var postId = Guid.NewGuid().ToString();
        var postPostId = Guid.NewGuid().ToString();
        var postName = "name";
        var postType = PostType.Assistant;
        var salary = 10;
        var isActual = false;
        var changeDate = DateTime.UtcNow.AddDays(-1);
        var post = CreateDataModel(postId, postPostId, postName, postType, salary, isActual, changeDate);
        Assert.That(() => post.Validate(), Throws.Nothing);
        Assert.Multiple(() =>
        {
            Assert.That(post.Id, Is.EqualTo(postId));
            Assert.That(post.PostId, Is.EqualTo(postPostId));
            Assert.That(post.PostName, Is.EqualTo(postName));
            Assert.That(post.PostType, Is.EqualTo(postType));
            Assert.That(post.Salary, Is.EqualTo(salary));
            Assert.That(post.IsActual, Is.EqualTo(isActual));
            Assert.That(post.ChangeDate, Is.EqualTo(changeDate));
        });
    }

    private static PostDataModel CreateDataModel(string? id, string? postId, string? postName, PostType postType, double salary, bool isActual, DateTime changeDate) =>
        new(id, postId, postName, postType, salary, isActual, changeDate);
}
