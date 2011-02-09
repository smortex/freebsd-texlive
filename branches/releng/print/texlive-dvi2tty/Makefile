# New ports collection makefile for:	texlive-dvi2tty
# Date created:		13/03/2010 04:24:02
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	dvi2tty
PORTVERSION=	20110209
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Produce ASCII from DVI.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
