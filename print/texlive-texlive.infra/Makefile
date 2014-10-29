# $FreeBSD$

PORTNAME=	texlive.infra
PORTVERSION=	20140523
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	basic TeX Live infrastructure

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
