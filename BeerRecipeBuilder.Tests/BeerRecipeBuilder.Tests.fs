module BeerRecipeBuilder.Tests.BrewingEquationsTests
open NUnit.Framework
open FsUnit
open BeerRecipeBuilder.BrewingEquations

 [<Test>]
let ``AAU equation with input of 1.5 ounces and 5 AA percentage`` () = 
    alphaAcidUnit 1.5 5.0 
    |> should equal 7.5

[<Test>]
let ``ABV equation with original gravity of 1.062 and final gravity of 1.012`` () =
    alcoholByVolume 1.062 1.012
    |> should equal 6.550000000000006

[<Test>]
let ``Boil Gravity with stuff`` () =
    boilGravity 5.5 42.0 6.0
    |> should equal 38.500000
        
[<EntryPoint>]
let main _ = 0

