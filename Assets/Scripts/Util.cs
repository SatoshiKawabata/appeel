// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
public class Util
{
	public Util ()
	{
	}

	public static float map(float value, float inputMin, float inputMax, float outputMin, float outputMax, bool clamp = false) {
//
//		if (Math.Abs(inputMin - inputMax) < FLT_EPSILON){
//			return outputMin;
//		} else {
			float outVal = ((value - inputMin) / (inputMax - inputMin) * (outputMax - outputMin) + outputMin);
			
			if( clamp ){
				if(outputMax < outputMin){
					if( outVal < outputMax )outVal = outputMax;
					else if( outVal > outputMin )outVal = outputMin;
				}else{
					if( outVal > outputMax )outVal = outputMax;
					else if( outVal < outputMin )outVal = outputMin;
				}
			}
			return outVal;
//		}
	}
}
