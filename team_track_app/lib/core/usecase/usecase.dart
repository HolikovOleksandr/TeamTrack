import 'package:team_track_app/core/resources/responce_state.dart';

abstract class UseCase<Type, Params> {
  Future<ResponceState<List<Type>>> getAll();

  Future<ResponceState<Type>> getOneById(Params id);

  Future<ResponceState<List<Type>>> create(Type newItem);

  Future<ResponceState<Type>> update(Type updateItem);

  Future<ResponceState<List<Type>>> delete(Params id);
}
