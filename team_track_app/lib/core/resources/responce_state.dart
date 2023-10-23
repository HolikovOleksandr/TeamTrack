// ignore_for_file: deprecated_member_use
import 'package:dio/dio.dart';

abstract class ResponceState<T> {
  final T? data;
  final DioError? error;

  const ResponceState({this.data, this.error});
}

class ResponceSuccess<T> extends ResponceState<T> {
  const ResponceSuccess(T data) : super(data: data);
}

class ResponceFailed<T> extends ResponceState<T> {
  const ResponceFailed(DioError error) : super(error: error);
}
