# New ports collection makefile for:	texlive-bin-dvipdfm
# Date created:		26/01/2009 16:02:46
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-dvipdfm
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A DVI driver to produce PDF directly.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
