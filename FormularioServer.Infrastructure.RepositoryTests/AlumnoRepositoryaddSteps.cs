using System;
using FluentAssertions;
using FormularioServer.Common.Model;
using FormularioServer.Infrastructure.Repository.Repositories;
using TechTalk.SpecFlow;

namespace FormularioServer.Infrastructure.RepositoryTests1
{
    [Binding]
    public class AlumnoRepositorySteps
    {
        protected AlumnoRepository repository = new AlumnoRepository();
        protected Alumno alumno;
        [Given(@"I have a Alumno without Id")]
        public void GivenIHaveAAlumnoWithoutId()
        {
            alumno = repository.ParseJSON("Manu", "Gutierrez", "9478854F");
        }

        [When(@"I run the method Insert of Student Repository")]
        public void WhenIRunTheMethodInsertOfStudentRepository()
        {
            repository.add(alumno);
        }

        [Then(@"the Student Repoditory should return an Alumno Id")]
        public void ThenTheStudentRepoditoryShouldReturnAnAlumnoId()
        {
            alumno.IdAlmuno.Should().Be(4);
        }
    }
}