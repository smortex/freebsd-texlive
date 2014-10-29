# $FreeBSD$

PORTNAME=	match_parens
PORTVERSION=	20140426
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Easily detect mismatched parens.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
