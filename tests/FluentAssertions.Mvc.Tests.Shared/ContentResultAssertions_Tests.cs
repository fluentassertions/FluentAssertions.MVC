﻿using System;
using System.Text;
using NUnit.Framework;
using System.Web.Mvc;

namespace FluentAssertions.Mvc.Tests
{
    [TestFixture]
    public class ContentResultAssertions_Tests
    {
        [Test]
        public void WithContent_GivenExpected_ShouldPass()
        {
            ActionResult result = new ContentResult {Content = "content"};
            result.Should().BeContentResult().WithContent("content");
        }

        [Test]
        public void WithContent_GivenUnexpected_ShouldFail()
        {
            var actualContent = "content";
            var expectedContent = "xyz";
            ActionResult result = new ContentResult { Content = actualContent };
            var failureMessage = String.Format(FailureMessages.CommonFailMessage, "ContentResult.Content", expectedContent, actualContent);

            Action a = () => result.Should().BeContentResult().WithContent(expectedContent);
            
            a.Should().Throw<Exception>()
                    .WithMessage(failureMessage);
        }

        [Test]
        public void WithContentType_GivenExpected_ShouldPass()
        {
            ActionResult result = new ContentResult { ContentType = "text/html" };
            result.Should().BeContentResult().WithContentType("text/html");
        }

        [Test]
        public void WithContentType_GivenUnexpected_ShouldFail()
        {
            var actualContentType = "text/html";
            var expectedContentType = "xyz";
            ActionResult result = new ContentResult { ContentType = actualContentType };
            var failureMessage = String.Format(FailureMessages.CommonFailMessage, "ContentResult.ContentType", expectedContentType, actualContentType);

            Action a = () => result.Should().BeContentResult().WithContentType(expectedContentType);
            
            a.Should().Throw<Exception>()
                    .WithMessage(failureMessage);
        }

        [Test]
        public void WithContentEncoding_GivenExpected_ShouldPass()
        {
            ActionResult result = new ContentResult { ContentEncoding = Encoding.ASCII };
            result.Should().BeContentResult().WithContentEncoding(Encoding.ASCII);
        }

        [Test]
        public void WithContentEncoding_GivenUnexpected_ShouldFail()
        {
            var actualEncoding = Encoding.ASCII;
            var expectedEncoding = Encoding.Unicode;
            ActionResult result = new ContentResult { ContentEncoding = actualEncoding };
            var failureMessage = String.Format(FailureMessages.CommonFailMessage, "ContentResult.ContentEncoding", expectedEncoding, actualEncoding);

            Action a = () => result.Should().BeContentResult().WithContentEncoding(expectedEncoding);
            
            a.Should().Throw<Exception>()
                    .WithMessage(failureMessage);
        }
    }
}
