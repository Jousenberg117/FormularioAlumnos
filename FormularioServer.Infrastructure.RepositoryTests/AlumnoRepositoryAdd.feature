Feature: AlumnoRepositoryadd
add Alumno in Alumno Repository 

@mytag
Scenario: insert an Alumno 
	Given I have a new Alumno without Id
	When I run the method add of Alumno Repository
	Then the Alumno Repoditory should return an Alumno Id
