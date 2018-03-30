type Item = 
  {Name: string
   Description: string}

type BeerStyleCategory =
    { Item: Item}

type BeerStyle = 
    { Item: Item
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
    {Item: Item
     OriginCountry: string
     alphaAcidUnitMin: decimal
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

type Srm = 
  {Name: string
   Hex: string}