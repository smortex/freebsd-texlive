# $FreeBSD$

PORTNAME=	mfware
PORTVERSION=	20140429
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Supporting tools for use with Metafont.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
