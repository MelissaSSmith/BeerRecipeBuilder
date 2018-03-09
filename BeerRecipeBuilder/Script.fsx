#load "BrewingEquations.fs"
open BeerRecipeBuilder.BrewingEquations

let aau = alphaAcidUnit 1.5 5.0
let bug = hopBitternessUnitsOzGal 1.5 5.0 (hopUtilization 60.0 1.070) 5.0
let bul = hopBitternessUnitsGramsLiter 42.5 5.0 (hopUtilization 60.0 1.070) 19.0
let gb = boilGravity 5.5 42.0 6.0
let abv = alcoholByVolume 1.070 1.012
let hu = hopUtilization 60.0 1.070
let att = attenuation 1.070 1.012

printfn "The AAU of the hops is: %f" aau
printfn "Estimated ABV is: %f" abv
printfn "Hop Utilization is: %f" hu
printfn "Attentuation is: %f" att
printfn "BU using ounces is: %f" bug
printfn "BU using grams is: %f" bul
printfn "The Boil Gravity is: %f" gb