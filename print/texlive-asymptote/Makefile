# $FreeBSD$

PORTNAME=	asymptote
PORTVERSION=	20160827
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	2D and 3D TeX-Aware Vector Graphics Language

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
