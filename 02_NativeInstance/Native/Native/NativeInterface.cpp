//
//  NativeInterface.cpp
//  Native
//
//  Created by Shogo Nakamura on 2017/10/26.
//  Copyright © 2017 com.shogonir. All rights reserved.
//

#include "NativeInterface.hpp"

NativeCounter* com_shogonir_NativeCounter_Create()
{
    return new NativeCounter();
}

void com_shogonir_NativeCounter_Destroy(NativeCounter* instance)
{
    if (instance == nullptr)
    {
        return;
    }
    
    delete instance;
    instance = nullptr;
}

void com_shogonir_NativeCounter_Increment(NativeCounter* instance)
{
    if (instance == nullptr)
    {
        return;
    }
    
    instance->Increment();
}

int com_shogonir_NativeCounter_GetCount(NativeCounter* instance)
{
    if (instance == nullptr)
    {
        return -1;
    }
    
    return instance->GetCount();
}
