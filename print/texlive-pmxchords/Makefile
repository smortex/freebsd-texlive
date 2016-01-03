# $FreeBSD$

PORTNAME=	pmxchords
PORTVERSION=	20160101
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Produce chord information to go with pmx output

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
