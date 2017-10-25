//
//  NativeCounter.cpp
//  Native
//
//  Created by Shogo Nakamura on 2017/10/26.
//  Copyright © 2017 com.shogonir. All rights reserved.
//

#include "NativeCounter.hpp"

NativeCounter::NativeCounter()
{
    count = 0;
}

NativeCounter::~NativeCounter()
{
    
}

void NativeCounter::Increment()
{
    count++;
}

int NativeCounter::GetCount()
{
    return count;
}
