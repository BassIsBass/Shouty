using System;
using TechTalk.SpecFlow;

namespace Shouty.Specs.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {

        private Person lucy = new Person();
        private Person sean = new Person();

        private string messageFromSean = "";

        [Given("Lucy is located {int}m from Sean")]
        public void GivenLucyIsLocatedMFromSean(int distance)
        {
            lucy.MoveTo(distance);
        }

        [When("Sean shouts {string}")]
        public void WhenSeanShouts(string message)
        {
            sean.Shouts(message);
            messageFromSean = message;
        }

        [Then("Lucy hears Sean's message")]
        public void ThenLucyHearsSeansMessage()
        {
            Assert.Contains(messageFromSean, lucy.MessageHeard());
        }
    }
}
