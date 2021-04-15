// F#

// Immutable data structure
type Bond = 
    { InstrumentId: string
      Coupon: float }

type Bonds = Bond of Bond | Hej of float

let b1 = { InstrumentId = "ID1"; Coupon = 2.0 }

// with syntax to work with it (copy and update)
let b2 = { b1 with InstrumentId = "ID2" }
let b3 = { b1 with InstrumentId = "ID3"; Coupon = 0.0 }

for b in [b1; b2; b3] do
  printfn "%A" b