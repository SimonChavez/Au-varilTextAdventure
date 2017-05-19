#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_TextController_States2214569690.h"

// UnityEngine.UI.Text
struct Text_t356221433;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// TextController
struct  TextController_t949652095  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text TextController::text
	Text_t356221433 * ___text_2;
	// TextController/States TextController::myState
	int32_t ___myState_3;

public:
	inline static int32_t get_offset_of_text_2() { return static_cast<int32_t>(offsetof(TextController_t949652095, ___text_2)); }
	inline Text_t356221433 * get_text_2() const { return ___text_2; }
	inline Text_t356221433 ** get_address_of_text_2() { return &___text_2; }
	inline void set_text_2(Text_t356221433 * value)
	{
		___text_2 = value;
		Il2CppCodeGenWriteBarrier(&___text_2, value);
	}

	inline static int32_t get_offset_of_myState_3() { return static_cast<int32_t>(offsetof(TextController_t949652095, ___myState_3)); }
	inline int32_t get_myState_3() const { return ___myState_3; }
	inline int32_t* get_address_of_myState_3() { return &___myState_3; }
	inline void set_myState_3(int32_t value)
	{
		___myState_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
