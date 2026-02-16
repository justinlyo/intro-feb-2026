
using Alba;
using MuddiestMoment.Api.Student.Endpoints;

namespace MuddiestMoment.Tests.Student;

public class AddsMoment
{
    [Fact]
    public async Task CanAddAMoment()
    {
        var host = await AlbaHost.For<Program>();


        var itemToSend = new StudentMomentCreateModel
        {
            Title = "Containers",
            Description = "Tell me about volumes"
        };

        var response = await host.Scenario(api =>
        {
            api.Post.Json(itemToSend).ToUrl("/student/moments");
            api.StatusCodeShouldBeOk();
        });

    }



}





/* POST https://localhost:1337/student/moments

*/