//
//  NativeInterface.hpp
//  Native
//
//  Created by Shogo Nakamura on 2017/10/26.
//  Copyright © 2017 com.shogonir. All rights reserved.
//

#ifndef NativeInterface_hpp
#define NativeInterface_hpp

#include <stdio.h>
#include "NativeCounter.hpp"

extern "C"
{
    NativeCounter* com_shogonir_NativeCounter_Create();
    void com_shogonir_NativeCounter_Destroy(NativeCounter* instance);
    void com_shogonir_NativeCounter_Increment(NativeCounter* instance);
    int com_shogonir_NativeCounter_GetCount(NativeCounter* instance);
}

#endif /* NativeInterface_hpp */
