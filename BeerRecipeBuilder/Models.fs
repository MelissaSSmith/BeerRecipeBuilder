type Details =
    { Name: string
      Description: string}

type BeerStyleCategory =
    { Details: Details}

type Country = 
    {IsoCode: string
     Name: string
     IsoThree: string
     numberCode: int}

type HopForm =
    | Pellet 
    | Plug
    | Leaf

type HopUse =
    | Boil
    | DryHop
    | Mash
    | FirstWort
    | Aroma

type YeastTypes =
    | Ale
    | Lager
    | Wheat
    | Wine
    | Champagne

type YeastForms =
    | Liquid
    | Dry
    | Slant
    | Culture

type FermentableType =
    | Grain
    | Sugar
    | Extract
    | DryExtract
    | Adjunct

type RecipeTypes =
    | Extract
    | AllGrain
    | PartialMash
   
type Choice =
    | Yes
    | No

type Srm = 
  {Name: string
   Hex: string}

type BeerStyle = 
    { Details: Details
      ShortName: string
      StyleCategory: BeerStyleCategory
      ibuMin: decimal
      ibuMax: decimal
      abvMin: decimal
      abvMax: decimal
      srmMin: decimal
      srmMax: decimal
      ogMin: decimal
      ogMax: decimal option
      fgMin: decimal
      fgMax: decimal}

type Hops = 
    { Details: Details
      OriginCountry: Country
      alphaAcidMin: decimal
      betaAcidMin: decimal
      betaAcidMax: decimal
      humuleneMin: decimal
      humuleneMax: decimal
      carophylleneMin: decimal
      carophylleneMax: decimal
      cohumuloneMax: decimal
      cohumuloneMin: decimal
      myrceneMin: decimal
      myrceneMax: decimal
      farneseneMin: decimal
      farneseneMax: decimal}

type Yeast =
    { Details: Details
      YeastType: YeastTypes
      AttenuationMin: decimal
      AttenuationMax: decimal
      fermentTempMin: decimal
      fermentTempMax: decimal
      alcoholToleranceMin: decimal
      alcoholToleranceMax: decimal
      ProductId: string
      Supplier: string
      YeastForm: YeastForms
    }

type Characteristic =
    { Details: Details}

type Fermentable = 
    { Details: Details
      CountryOfOrigin: Country
      Srm: Srm
      MoistureContent: decimal
      CoarseFineDifference: decimal
      DiastaticPower: decimal
      DryYield: decimal
      Potential: decimal
      Protein: decimal
      MaxInBatch: decimal
      RequiresMashing: Choice
      Characteristics: Characteristic list
    }