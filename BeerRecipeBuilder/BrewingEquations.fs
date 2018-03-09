module BeerRecipeBuilder.BrewingEquations
open System

let functionOfTime (time : float) = (1.0 - Math.Pow(Math.E, -0.04 * time)) / 4.15

let functionOfGravity (boilGravity : double) = 1.65 * Math.Pow(0.000125, (boilGravity - 1.0))

let alphaAcidUnit (ouncesOfHops : float) (aAPercentage : float) = 
    ouncesOfHops * aAPercentage

let hopBitternessUnitsOzGal (ouncesOfHops : float) (aAPercentage : float) (utilizationPercentage : float) (finalVolume : float) = 
    ouncesOfHops * aAPercentage * utilizationPercentage * (75.0 / finalVolume)

let hopBitternessUnitsGramsLiter (gramsOfHops : float) (aAPercentage : float) (utilizationPercentage : float) (finalVolume : float) = 
    gramsOfHops * aAPercentage * utilizationPercentage * (10.0 / finalVolume)

let boilGravity (massOfExtract : float) (poundPerGallon : float) (wortVolume : float) = 
    (massOfExtract * poundPerGallon) / wortVolume

let alcoholByVolume (originalGravity : float) (finalGravity : float) =
    (originalGravity - finalGravity) * 131.0

let hopUtilization (time : float) (boilGravity : double) = functionOfTime time * functionOfGravity boilGravity

let attenuation (originalGravity : float) (finalGravity : float) =
    (originalGravity - finalGravity) / (originalGravity - 1.0)

let maltRequiredPPG = 0

let maltRequiredPKL = 0

let weightOfActualExtract (wortVolume : float) (wortDensity : float) (percentageExtractInWort : float) =
    wortVolume * wortDensity * percentageExtractInWort

let weightOfMaximunExtract (maltWeight : float) (maximumYield : float) =
    maltWeight * maximumYield

let brewingEfficiency (wortVolume : float) (wortDensity : float) (percentageExtractInWort : float) (maltWeight : float) (maximumYield : float) = 
    weightOfActualExtract wortVolume wortDensity percentageExtractInWort / weightOfMaximunExtract maltWeight maximumYield