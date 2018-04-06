module BeerRecipeBuilder.BrewingEquations
open System

let functionOfTime time : float = (1.0 - Math.Pow(Math.E, -0.04 * time)) / 4.15

let functionOfGravity boilGravity : double = 1.65 * Math.Pow(0.000125, (boilGravity - 1.0))

let alphaAcidUnit ouncesOfHops aAPercentage : float = 
    ouncesOfHops * aAPercentage

let hopBitternessUnitsOzGal ouncesOfHops aAPercentage utilizationPercentage finalVolume : float = 
    ouncesOfHops * aAPercentage * utilizationPercentage * (75.0 / finalVolume)

let hopBitternessUnitsGramsLiter gramsOfHops aAPercentage utilizationPercentage finalVolume : float = 
    gramsOfHops * aAPercentage * utilizationPercentage * (10.0 / finalVolume)

let boilGravity massOfExtract poundPerGallon wortVolume : float = 
    (massOfExtract * poundPerGallon) / wortVolume

let alcoholByVolume originalGravity finalGravity : float =
    (originalGravity - finalGravity) * 131.0

let hopUtilization time boilGravity : double = 
    functionOfTime time * functionOfGravity boilGravity

let attenuation originalGravity finalGravity : float =
    (originalGravity - finalGravity) / (originalGravity - 1.0)

let maltRequiredPPG = 0

let maltRequiredPKL = 0

let weightOfActualExtract wortVolume wortDensity percentageExtractInWort : float =
    wortVolume * wortDensity * percentageExtractInWort

let weightOfMaximunExtract maltWeight maximumYield : float =
    maltWeight * maximumYield

let brewingEfficiency wortVolume wortDensity percentageExtractInWort maltWeight maximumYield : float = 
    weightOfActualExtract wortVolume wortDensity percentageExtractInWort 
    / weightOfMaximunExtract maltWeight maximumYield