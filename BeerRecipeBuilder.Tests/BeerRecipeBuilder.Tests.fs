module BeerRecipeBuilder.Tests.BrewingEquationsTests
open NUnit.Framework
open FsUnit
open BeerRecipeBuilder.BrewingEquations

[<TestFixture>]
type TestClass () = 

    [<Test>]
    let ``AAU equation with input of 1.5 ounces and 5 AA percentage`` () = 
        alphaAcidUnit 1.5 5.0 |> should equal 7.5
