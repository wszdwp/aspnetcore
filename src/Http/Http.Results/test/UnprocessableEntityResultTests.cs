// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;

namespace Microsoft.AspNetCore.Http.Result
{
    public class UnprocessableEntityResultTests
    {
        [Fact]
        public void UnprocessableEntityResult_InitializesStatusCode()
        {
            // Arrange & act
            var result = new UnprocessableEntityResult();

            // Assert
            Assert.Equal(StatusCodes.Status422UnprocessableEntity, result.StatusCode);
        }
    }
}
